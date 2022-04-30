using System;

namespace Bat_Gadgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman batman = new Batman();
            batman.SetBatGadget(new BatGadgetCape("Batarang"));
            batman.SetBatGadget(new BatGadgetCape("Bat-ordinateur"));
            batman.SetBatGadget(new BatGadgetCape("Bat-crochet"));


            BatVehicule batmobile = new BatVehicule("Bat-Mobile");
            batmobile.SetBatGadget(new BatGadgetVehicule("autopilote"));
            batmobile.SetBatGadget(new BatGadgetVehicule("autoprotection"));
            batmobile.SetBatGadget(new BatGadgetVehicule("Vulcan Gun 25mm"));

            BatGadget batGadget = (BatGadget)new BatGadgetVehicule("oui");

            batmobile.GetDescription();
        }
    }
}
