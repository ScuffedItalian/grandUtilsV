using System;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace grandUtilsV1 //Your Mod Name Here
{
    public class Main : Script
    {
        Vehicle car;

        public Main()
        {
            
            Tick += onTick;
            KeyDown += onKeyDown;
        }
        private void onTick(object sender, EventArgs e)
        {

        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Z)
            {
                GTA.UI.Screen.ShowHelpText("L: Invincibility" +
                    "\r\nI: Sets wanted level to 0" +
                    "\r\nK: Max Armor" +
                    "\r\nJ : Sets Wanted level to level 5" +
                    "\r\nH: Spawns the Adder" +
                    "\r\nU: Repair your adder you spawned in" +
                    "\r\nN: Shows script stats" +
                    "\r\nY: Disabled invincibility ");
            }

            if(e.KeyCode == Keys.Y)
            {
                Game.Player.IsInvincible = false;
                GTA.UI.Notification.Show("Invin set to false");
            }

            if(e.KeyCode == Keys.N)
            {
                GTA.UI.Notification.Show("Developer ScuffedItalian \r\nVersion: 1.0 \r\nScriptHookVDotNet V3");
            }

            if(e.KeyCode == Keys.I)
            {
                Game.Player.WantedLevel = 0;
                GTA.UI.Notification.Show("Set Wanted level to 0");
            }


            if(e.KeyCode == Keys.L)
            {
                Game.Player.IsInvincible = true;
                GTA.UI.Notification.Show("Set invin to true!");

            }
            if(e.KeyCode == Keys.K)
            {
                Game.Player.MaxArmor = 100;
                GTA.UI.Notification.Show("+100 Armor");
            }
            if(e.KeyCode == Keys.J)
            {
                Game.Player.WantedLevel = 5;
                GTA.UI.Notification.Show("Wanted level is 5 now, you're a bad boy!!!!");
            }
             

            
            if(e.KeyCode == Keys.H)
            {
                car = World.CreateVehicle(VehicleHash.Adder, Game.Player.Character.GetOffsetPosition(new Vector3(0, 5, 0)));
                GTA.UI.Notification.Show("Sick whip spawned");
            }
            if(e.KeyCode == Keys.U)
            {
                car.Repair();
                GTA.UI.Notification.Show("Sick whip repaired!");
            }



        }
    }
}