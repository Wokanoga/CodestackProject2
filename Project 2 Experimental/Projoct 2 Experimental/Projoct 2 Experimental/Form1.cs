using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Projoct_2_Experimental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTextFiles();
            
        }
        public void LoadTextFiles()
        {
            //Folder Level1
            StreamReader FightAnUnderling           = new StreamReader("TextFiles/Level1/FightAnUnderling.txt");
            StreamReader GabeNewellLose             = new StreamReader("TextFiles/Level1/GabeNewellLose.txt");
            StreamReader GabeNewellWin              = new StreamReader("TextFiles/Level1/GabeNewellWin.txt");
            StreamReader GolfClub                   = new StreamReader("TextFiles/Level1/GolfClub.txt");
            StreamReader Intro1                     = new StreamReader("TextFiles/Level1/Intro.txt");
            StreamReader JarJarBinksLose            = new StreamReader("TextFiles/Level1/JarJarBinksLose.txt");
            StreamReader JarJarBinksWin             = new StreamReader("TextFiles/Level1/JarJarBinksWin.txt");
            StreamReader PickAnUnderling            = new StreamReader("TextFiles/Level1/PickAnUnderling.txt");
            StreamReader Racquet                    = new StreamReader("TextFiles/Level1/Racquet.txt");
            StreamReader ReggieFilsAimeLose         = new StreamReader("TextFiles/Level1/ReggieFilsAimeLose.txt");
            StreamReader ReggieFilsAlmeWin          = new StreamReader("TextFiles/Level1/ReggieFilsAimeWin.txt");
            StreamReader SelectAWeapon              = new StreamReader("TextFiles/Level1/SelectAWeapon.txt");
            
            //Folder Level2
            StreamReader BoardOfInterviewersFails   = new StreamReader("TextFiles/Level2/BoardOfInterviewersFails.txt");
            StreamReader BoardOfInterviewersSucceed = new StreamReader("TextFiles/Level2/BoardOfInterviewersSucceed.txt");
            StreamReader Intro2                     = new StreamReader("TextFiles/Level2/Intro.txt");
            StreamReader SelectBoardOrSLP           = new StreamReader("TextFiles/Level2/SelectBoardOrSPL.txt");
            StreamReader SelectTobeyOrBoard         = new StreamReader("TextFiles/Level2/SelectTobeyOrBoard.txt");
            StreamReader SelectTobeyOrSLP           = new StreamReader("TextFiles/Level2/SelectTobeyOrSPL.txt");
            StreamReader SPLFail                    = new StreamReader("TextFiles/Level2/SPLFail.txt");
            StreamReader SPLSucceed                 = new StreamReader("TextFiles/Level2/SPLSucceed.txt");
            StreamReader TobeyFail                  = new StreamReader("TextFiles/Level2/TobeyFail.txt");
            StreamReader TobeySucceed               = new StreamReader("TextFiles/Level2/TobeySucceed.txt");

            //Folder Level3
            //StreamReader = new StreamReader("textFiles/Level3/.txt");


        }
    }
}
