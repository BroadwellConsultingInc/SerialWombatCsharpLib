using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public partial class MemoryPageEditor : UserControl
    {
        List<MemoryLineEditor> memoryLineEditors = new List<MemoryLineEditor>();
        List<ByteEditor> byteEditors = new List<ByteEditor>();

        public EventHandler <MemoryWriteEventArgs> TypedChange;
        byte[] data;

        UInt32 address = 0;
        public MemoryPageEditor()
        {
            InitializeComponent();
            int y = 0;
            for (int i = 0; i < 16; ++i)
            {
                MemoryLineEditor e = new MemoryLineEditor();
                byteEditors = byteEditors.Concat(e.ByteEditors).ToList();
                e.Top = y;
                this.Controls.Add(e);
                y += e.Height;
                memoryLineEditors.Add(e);


            }
            Address = 0;
            trackBar1.Top = memoryLineEditors[0].Top;
            trackBar1.Height = memoryLineEditors.Last().Bottom - memoryLineEditors[0].Top;
            trackBar1.Left = memoryLineEditors[0].Right;
            trackBar1.Value = trackBar1.Maximum;

            {
                foreach (ByteEditor b in byteEditors)
                {
                    b.onTypedChange += betypedChange;
                }
                
            }
        }

        protected virtual void OnTypedChange(MemoryWriteEventArgs e)
        {
            EventHandler<MemoryWriteEventArgs> handler = TypedChange;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void betypedChange(object sender, EventArgs e)
        {
            int bei = getIndexFromByteEditor(sender);
            ByteEditor be = (ByteEditor)(sender);
            MemoryWriteEventArgs mwea = new MemoryWriteEventArgs();
            mwea.Value = be.Value;
            mwea.Address = (UInt32)(bei + address);
            TypedChange?.Invoke(this,mwea);
        }

        void updateAddresses()
        {
            UInt32 a = address;
            foreach (MemoryLineEditor e in memoryLineEditors)
            {
                e.Address = a;
                a += 16;
            }
        }
        public UInt32 Address
        {
            get { return address; }
            set { address = value; updateAddresses(); }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Address =(UInt32)( (trackBar1.Maximum  - trackBar1.Value) * 16);
            updateByteEditors();
        }

        void updateByteEditors()
        {
            int i = 0;
            foreach (ByteEditor e in byteEditors)
            {
                e.Value = data[address + i];
                ++i;
            }
        }

        private int getByteEditorIndexFromToolStripItem (object sender)
        {
            int i = 0;
            int offset = -1;

            ByteEditor be = null;
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    TextBox sourceControl = null;
                    // Get the control that is displaying this context menu
                    sourceControl = (TextBox)owner.SourceControl;
                    be = sourceControl.Parent as ByteEditor;

                }
            }
            foreach (ByteEditor byteEditor in byteEditors)
            {
                if (byteEditor == be)
                {
                    offset = i;
                }
                ++i;
            }
            return offset;
        }

        private int getIndexFromByteEditor(object sender)
        {
            

            ByteEditor be = (ByteEditor) sender;
            int offset = -1;
            int i = 0;
            foreach (ByteEditor byteEditor in byteEditors)
            {
                if (byteEditor == be)
                {
                    offset = i;
                }
                ++i;
            }
            return offset;
        }
        private ByteEditor getByteEditorFromToolStripItem(object sender)
        {
            int i = 0;
            int offset = -1;

            ByteEditor be = null;
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    TextBox sourceControl = null;
                    // Get the control that is displaying this context menu
                    sourceControl = (TextBox)owner.SourceControl;
                    be = sourceControl.Parent as ByteEditor;

                }
            }
            foreach (ByteEditor byteEditor in byteEditors)
            {
                if (byteEditor == be)
                {
                    return (be);
                }
            }
            return null;
        }

        public void SetData(byte[] d)
        {
            data = (byte[])d.Clone();
            try
            {
                trackBar1.Maximum = (data.Length - 256) / 16 ;
            }
            catch
            {
                trackBar1.Maximum = 0;
            }
            trackBar1.Enabled = true;
            trackBar1.Value = trackBar1.Maximum;
            updateByteEditors();
        }

       
    }

    public class MemoryWriteEventArgs : EventArgs
    {
        public UInt32 Address { get; set; }
        public byte Value { get; set; }
    }
}
