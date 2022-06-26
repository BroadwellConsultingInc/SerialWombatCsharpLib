using NUnit.Framework;
using SerialWombat;

using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Threading;

namespace SerialWombatUnitTests
{
    public class TestSetup
    {
        public static string WombatUnderTestPort = "COM5";
        public static string WombatVerifyingOoutputPort = "COM11";
        public static List<SerialWombatPacket> PacketLog = new List<SerialWombatPacket>();

        public static byte[] OutputToInputPinMap = { 1, 0, 3, 2 };

        public static int[] ServoTestInitialPulseLoop = { 500, 1500, 500 };
        public static int[] ServoTestVariablePulseLoop = { 500, 1500, 250 };
        public static int[] ServoTestPositionLoop = { 0, 65535, 2500 };

    }



    public class BasicProtocolTests
    {
        SerialWombatChip WombatUnderTest = new SerialWombatChip();
        SerialWombatChip WombatVerifyingOutput = new SerialWombatChip();

        [SetUp]
        public void Setup()
        {
            WombatUnderTest.begin(TestSetup.WombatUnderTestPort);
            WombatUnderTest.hardwareReset();
            Thread.Sleep(50);

        }

        [TearDown]
        public void TearDown()
        {
            WombatUnderTest.Serial.Port.Close();
        }

        [Test]

        public void EchoTest()
        {
            Random r = new Random(1);
            for (int i = 0; i < 10000; ++i)
            {

                byte[] data = new byte[7];
                for (int x = 0; x < 7; ++x)
                {
                    data[x] = (byte)r.Next(255);
                }
                byte[] rx;
                Int16 result = WombatUnderTest.echo(data, out rx);
                Assert.IsTrue(result >= 0);
                if ( result >= 0)
                {
                    for (int x = 0; x < 7; ++x)
                    {
                        Assert.IsTrue(data[x] == rx[x]);
                    }
                }
                else
                {

                }

            }
        }

        [Test]

        public void VsupplyTest()
        {

            UInt16 supplyVoltage = WombatUnderTest._supplyVoltagemV;
            Assert.IsTrue( supplyVoltage > 2800 && supplyVoltage < 3400 );
        }
    }
}
