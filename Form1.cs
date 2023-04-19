using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2Makso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            MPlate Gigabyte1 = new MPlate("Gigabyte motherboard 120382");
            MPlate Gigabyte2 = new MPlate("Gigabyte motherboard 456456");

            PBlock Block1 = new PBlock("Block1", 200);
            PBlock Block2 = new PBlock("Block2", 250);

            Processor AMD1 = new Processor("AMD");
            Processor AMD2 = new Processor("AMD");
            Processor INTEL1 = new Processor("INTEL");
            Processor INTEL2 = new Processor("INTEL");

            SystemBlock SysBlock1 = new SystemBlock(Gigabyte1, Block1, AMD1);
            SystemBlock SysBlock2 = new SystemBlock(Gigabyte1, Block1, AMD1);
            SystemBlock SysBlock3 = new SystemBlock(Gigabyte1, Block1, INTEL1);
            SystemBlock SysBlock4 = new SystemBlock(Gigabyte1, Block1, INTEL1);

            List<SystemBlock> parts = new List<SystemBlock>();

            parts.Add(SysBlock1);
            parts.Add(SysBlock2);
            parts.Add(SysBlock3);
            parts.Add(SysBlock4);

            listView1.Items.Add(SysBlock1.ProcName);
            listView1.Items.Add(SysBlock2.ProcName);
            listView1.Items.Add(SysBlock3.ProcName);
            listView1.Items.Add(SysBlock4.ProcName);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

    class MPlate
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("Motherboard name: " + name);
        }

        public MPlate(string _name)
        {
            if (_name.Length >= 20 && _name.Length <= 150)
            {
                name = _name;
            }

            else
            {
                name = "defaultplatename";
            }
        }
    }

    class PBlock
    {
        private string name;
        private int power;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Power
        {
            get { return power; }
            set
            {
                power = value;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("Powerblock name: " + name + " " + power.ToString() + " W");
        }

        public PBlock(string _name, int _power)
        {
            name = _name;
            power = _power;
        }
    }

    class Processor
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("Processor name: " + name);
        }

        public Processor(string _name)
        {
            name = _name;
        }
    }

    class SystemBlock
    {
        public string PlateName;
        public string BlockName;
        public string ProcName;
        public int BlockPower;
        public SystemBlock (MPlate mp, PBlock pb, Processor pr)
        {
            PlateName = mp.Name;
            BlockName = pb.Name;
            ProcName = pr.Name;
            BlockPower = pb.Power;
        }
    }
}

