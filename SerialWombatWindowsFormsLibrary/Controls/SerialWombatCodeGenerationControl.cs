using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWombatWindowsFormsLibrary
{
    public class SerialWombatCodeGenerationControl : UserControl
    {
        public event EventHandler CodeGeneration;

        public CodeGenerationPlatform CodeGenerationTarget = CodeGenerationPlatform.Arduino;
        protected void CodeGenerated( CodeGenerationPlatform platform, string code )
        {

            CodeGeneratedEventArgs cgea = new CodeGeneratedEventArgs();
            cgea.Code = code;
            CodeGeneration?.Invoke(this, cgea);
        }
    }
    public class CodeGeneratedEventArgs : EventArgs
    {
        public string Code{ get; set; }
        public CodeGenerationPlatform Platform { get; set; }
    }

    public enum CodeGenerationPlatform
    {
        Arduino,
        Python,
        CSharp
    }

    public delegate void CodeGenerationDelegate(CodeGeneratedEventArgs e);
}
