using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSAutomationWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command;

namespace NSAutomationWin.Tests
{
    [TestClass()]
    public class CommandWrapperTests
    {
        [TestMethod()]
        public void WaitFromStringTest()
        {
            var originalWait = new Wait(365);
            var cw = new CommandWrapper(originalWait.ToString());
            Assert.IsTrue(cw.Command is Wait);
            Assert.AreEqual(originalWait.WaitTime, ((Wait)cw.Command).WaitTime);
        }

        [TestMethod()]
        public void OperateButtonFromStringTest()
        {
            var orignalOB = new OperateButton(ButtonID.X, ButtonState.PRESS);
            var cw = new CommandWrapper(orignalOB.ToString());
            Assert.IsTrue(cw.Command is OperateButton);
            var obFromString = (OperateButton)cw.Command;
            Assert.AreEqual(orignalOB.ButtonID, obFromString.ButtonID);
            Assert.AreEqual(orignalOB.TargetState, obFromString.TargetState);
        }

        [TestMethod()]
        public void OperateStickFromStringTest()
        {
            var orignalOS = new OperateStick(StickID.LSTICK, (byte)98, (byte)76);
            var cw = new CommandWrapper(orignalOS.ToString());
            Assert.IsTrue(cw.Command is OperateStick);
            var osFromString = (OperateStick)cw.Command;
            Assert.AreEqual(orignalOS.StickID, osFromString.StickID);
            Assert.AreEqual(orignalOS.TargetXAngle, osFromString.TargetXAngle);
            Assert.AreEqual(orignalOS.TargetYAngle, osFromString.TargetYAngle);
        }
    }
}