using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartupForm startForm = new StartupForm();
            startForm.Show();
        }
        public int findFinalScore(char[] scores)
        {
            int finalScore=0;
            for (int i = 0; i < 15; i = i + 2)
            {
                //ball 1
                if (scores[i] == '-')
                {
                    //ball 2
                    if (scores[i + 1] == '-')
                    {
                        finalScore = finalScore + 0;
                    }
                    else if (scores[i + 1] == '/')
                    {
                        //ball 3
                        if (scores[i + 2] == '-')
                        {
                            finalScore = finalScore + 10;

                        }
                        else if(scores[i+2] == 'x')
                        {
                            finalScore = finalScore + 20;
                        }
                        else
                        {
                            finalScore = finalScore + 10 + CharToInt(scores[i + 2]);
                        }
                    }
                    else
                    {
                        finalScore = finalScore + CharToInt(scores[i + 1]);
                    }

                }
                else if(scores[i] == 'x')
                {
                    //ball 3
                    if (scores[i + 2] == 'x')
                    {
                        //ball 5
                        if (scores[i + 4] == 'x')
                        {
                            finalScore = finalScore + 30;
                        }
                        else if (scores[i + 4] == '-')
                        {
                            finalScore = finalScore + 20;
                        }
                        else
                        {
                            finalScore = finalScore + 20 + CharToInt(scores[i + 4]);
                        }

                    }
                    else if (scores[i + 2] == '-')
                    {
                        //ball 4
                        if (scores[i + 3] == '/')
                        {
                            finalScore = finalScore + 20;
                        }
                        else if (scores[i + 3] == '-')
                        {
                            finalScore = finalScore + 10;
                        }
                        else
                        {
                            finalScore = finalScore + 10 + CharToInt(scores[i + 3]);
                        }
                    }
                    else
                    {
                        if (scores[i + 3] == '/')
                        {
                            finalScore = finalScore + 20;
                        }
                        else if (scores[i + 3] == '-')
                        {
                            finalScore = finalScore + 10 + CharToInt(scores[i + 2]);
                        }
                        else
                        {
                            finalScore = finalScore + 10 + CharToInt(scores[i + 2]) + CharToInt(scores[i + 3]);
                        }

                    }
                }
                else
                {
                    //ball 2
                    if (scores[i + 1] == '/')
                    {
                        //ball 3
                        if (scores[i + 2] == 'x')
                        {
                            finalScore = finalScore + 20;
                        }
                        else if (scores[i + 2] == '-')
                        {
                            finalScore = finalScore + 10;
                        } 
                        else
                        {
                            finalScore = finalScore + 10 + CharToInt(scores[i+2]);
                        }
                    }
                    else if (scores[i + 1] == '-')
                    {
                        finalScore = finalScore + CharToInt(scores[i]);
                    }
                    else
                    {
                        finalScore = finalScore + CharToInt(scores[i]) + CharToInt(scores[i + 1]);
                    }
                }

            }
            if (scores[16] == 'x')
            {
                if (scores[18] == 'x')
                {
                    if (scores[19] == 'x')
                    {
                        finalScore = finalScore + 30;
                    }
                    else if (scores[19] == '-')
                    {
                        finalScore = finalScore + 20;
                    }
                    else
                    {
                        finalScore = finalScore + 20 + CharToInt(scores[19]);
                    }
                }
                else if (scores[18] == '-')
                {
                    if (scores[19] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[19] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[19]);
                    }
                }
                else
                {
                    if (scores[19] == '/')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[19] == '-')
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[18]);
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[18]) + CharToInt(scores[19]);
                    }


                }

                

            }
            else if (scores[16] == '-')
            {
                if (scores[17] == '/')
                {
                    if (scores[18] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[18] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[18]);
                    }
                }
                else if (scores[17] == '-')
                {
                    finalScore = finalScore + 0;
                }
                else
                {
                    finalScore = finalScore + CharToInt(scores[17]);
                }
            }
            else
            {
                if (scores[17] == '/')
                {
                    if (scores[18] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[18] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[18]);
                    }
                }
                else if (scores[17] == '-')
                {
                    finalScore = finalScore + CharToInt(scores[16]);
                }
                else
                {
                    finalScore = finalScore + CharToInt(scores[16]) + CharToInt(scores[17]); 
                }
            }
            if (scores[18] == 'x')
            {
                if (scores[19] == 'x')
                {
                    if (scores[20] == 'x')
                    {
                        finalScore = finalScore + 30;
                    }
                    else if (scores[20] == '-')
                    {
                        finalScore = finalScore + 0;
                    }
                    else
                    {
                        finalScore = finalScore + 20 + CharToInt(scores[20]);
                    }
                    
                }
                else if (scores[19] == '-')
                {
                    if (scores[20] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[20] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[20]);
                    }
                }
                else
                {
                    if (scores[20] == '/')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[20] == '-')
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[19]);
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[19]) + CharToInt(scores[20]);
                    }

                }

            }
            else if(scores[18]=='-')
            {
                if (scores[19] == '/')
                {
                    if (scores[20] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[20] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + CharToInt(scores[20]);
                    }
                }
                else if (scores[19] == '-')
                {
                    finalScore = finalScore + 0;
                }
                else
                {
                    finalScore = finalScore + CharToInt(scores[19]);
                }

            }
            else
            {
                if (scores[19] == '/')
                {
                    if (scores[20] == 'x')
                    {
                        finalScore = finalScore + 20;
                    }
                    else if (scores[20] == '-')
                    {
                        finalScore = finalScore + 10;
                    }
                    else
                    {
                        finalScore = finalScore + 10 + scores[20];
                    }
                }
                else if (scores[19] == '-')
                {
                    finalScore = finalScore + CharToInt(scores[18]);
                }
                else
                {
                    finalScore = finalScore + CharToInt(scores[18]) + CharToInt(scores[19]);
                }
            }
            

                return finalScore;

        }
        public Boolean isArrayValid(char[] scores)
        {
            for (int i = 0; i < 21; i++)
            {
                if(scores[i] == '-'|| scores[i] == '1' || scores[i] == '2' || scores[i] == '3' || scores[i] == '4' || scores[i] == '5'
                    || scores[i] == '6' || scores[i] == '7' || scores[i] == '8' || scores[i] == '9' || scores[i] == '/' || scores[i] == 'x')
                {
                    
                }
                else
                {
                    return false;
                }
            }
            for (int i = 0; i < 18; i = i + 2)
            {
                if (scores[i] == '/')
                {
                    return false;
                }

            }
            for (int i = 1; i < 18; i = i + 2)
            {
                if (scores[i] == 'x')
                {
                    return false;
                }
            }
            for (int i = 0; i < 18; i = i+2)
            {
                if (scores[i] != 'x')
                {
                    if (scores[i + 1] != '/')
                    {
                        if (scores[i] != '-')
                        {
                            if (scores[i + 1] != '-')
                            {
                                if (CharToInt(scores[i]) + CharToInt(scores[i + 1]) >= 10)
                                {
                                    return false;
                                }
                            }
                        }

                    }
                }

            }
            for (int i = 0; i < 18; i = i + 2)
            {
                if (scores[i] == 'x')
                {
                    if (scores[i + 1] != '-')
                    {
                        return false;
                    }
                }
            }
            
                return true;
        }
        public static int CharToInt(char input)
        {
            double temp = Char.GetNumericValue(input);
            int result = Convert.ToInt32(temp);
            return result;
        }
        private void btnGetScore_Click(object sender, EventArgs e)
        {
            int PlOneNameLength = txtPlayerOne.TextLength;
            int PlTwoNameLength = txtPlayerTwo.TextLength;
            int PlThreeNameLength = txtPlayerThree.TextLength;
            int PlFourNameLength = txtPlayerFour.TextLength;
            ErrorForm errForm = new ErrorForm();
            if (PlOneNameLength > 0)
            {
                //input data into an array
                char[] plOneScores;
                plOneScores = new char[21];
                plOneScores[0] = Convert.ToChar(txt111.Text);
                plOneScores[1] = Convert.ToChar(txt112.Text);
                plOneScores[2] = Convert.ToChar(txt121.Text);
                plOneScores[3] = Convert.ToChar(txt122.Text);
                plOneScores[4] = Convert.ToChar(txt131.Text);
                plOneScores[5] = Convert.ToChar(txt132.Text);
                plOneScores[6] = Convert.ToChar(txt141.Text);
                plOneScores[7] = Convert.ToChar(txt142.Text);
                plOneScores[8] = Convert.ToChar(txt151.Text);
                plOneScores[9] = Convert.ToChar(txt152.Text);
                plOneScores[10] = Convert.ToChar(txt161.Text);
                plOneScores[11] = Convert.ToChar(txt162.Text);
                plOneScores[12] = Convert.ToChar(txt171.Text);
                plOneScores[13] = Convert.ToChar(txt172.Text);
                plOneScores[14] = Convert.ToChar(txt181.Text);
                plOneScores[15] = Convert.ToChar(txt182.Text);
                plOneScores[16] = Convert.ToChar(txt191.Text);
                plOneScores[17] = Convert.ToChar(txt192.Text);
                plOneScores[18] = Convert.ToChar(txt101.Text);
                plOneScores[19] = Convert.ToChar(txt102.Text);
                plOneScores[20] = Convert.ToChar(txt103.Text);
                //check if string is valid
                if (isArrayValid(plOneScores))
                {
                    //find overall score
                    int plOneFinal = findFinalScore(plOneScores);
                    label1.Text = Convert.ToString(plOneFinal);

                }
                else
                {
                    errForm.Show();
                }


            }

            
            if (PlTwoNameLength > 0) {
                //input data into an array
                char[] plTwoScores;
                plTwoScores = new char[21];
                plTwoScores[0] = Convert.ToChar(txt211.Text);
                plTwoScores[1] = Convert.ToChar(txt212.Text);
                plTwoScores[2] = Convert.ToChar(txt221.Text);
                plTwoScores[3] = Convert.ToChar(txt222.Text);
                plTwoScores[4] = Convert.ToChar(txt231.Text);
                plTwoScores[5] = Convert.ToChar(txt232.Text);
                plTwoScores[6] = Convert.ToChar(txt241.Text);
                plTwoScores[7] = Convert.ToChar(txt242.Text);
                plTwoScores[8] = Convert.ToChar(txt251.Text);
                plTwoScores[9] = Convert.ToChar(txt252.Text);
                plTwoScores[10] = Convert.ToChar(txt261.Text);
                plTwoScores[11] = Convert.ToChar(txt262.Text);
                plTwoScores[12] = Convert.ToChar(txt271.Text);
                plTwoScores[13] = Convert.ToChar(txt272.Text);
                plTwoScores[14] = Convert.ToChar(txt281.Text);
                plTwoScores[15] = Convert.ToChar(txt282.Text);
                plTwoScores[16] = Convert.ToChar(txt291.Text);
                plTwoScores[17] = Convert.ToChar(txt292.Text);
                plTwoScores[18] = Convert.ToChar(txt201.Text);
                plTwoScores[19] = Convert.ToChar(txt202.Text);
                plTwoScores[20] = Convert.ToChar(txt203.Text);
                //check if string is valid
                if (isArrayValid(plTwoScores))
                {
                    //find overall score
                    int plTwoFinal = findFinalScore(plTwoScores);
                    label2.Text = Convert.ToString(plTwoFinal);

                }
                else
                {
                    errForm.Show();
                }
            }
            if (PlThreeNameLength > 0) {
                //Calculate score for player three
                //input data into an array
                char[] plThreeScores;
                plThreeScores = new char[21];
                plThreeScores[0] = Convert.ToChar(txt311.Text);
                plThreeScores[1] = Convert.ToChar(txt312.Text);
                plThreeScores[2] = Convert.ToChar(txt321.Text);
                plThreeScores[3] = Convert.ToChar(txt322.Text);
                plThreeScores[4] = Convert.ToChar(txt331.Text);
                plThreeScores[5] = Convert.ToChar(txt332.Text);
                plThreeScores[6] = Convert.ToChar(txt341.Text);
                plThreeScores[7] = Convert.ToChar(txt342.Text);
                plThreeScores[8] = Convert.ToChar(txt351.Text);
                plThreeScores[9] = Convert.ToChar(txt352.Text);
                plThreeScores[10] = Convert.ToChar(txt361.Text);
                plThreeScores[11] = Convert.ToChar(txt362.Text);
                plThreeScores[12] = Convert.ToChar(txt371.Text);
                plThreeScores[13] = Convert.ToChar(txt372.Text);
                plThreeScores[14] = Convert.ToChar(txt381.Text);
                plThreeScores[15] = Convert.ToChar(txt382.Text);
                plThreeScores[16] = Convert.ToChar(txt391.Text);
                plThreeScores[17] = Convert.ToChar(txt392.Text);
                plThreeScores[18] = Convert.ToChar(txt301.Text);
                plThreeScores[19] = Convert.ToChar(txt302.Text);
                plThreeScores[20] = Convert.ToChar(txt303.Text);
                //check if string is valid
                if (isArrayValid(plThreeScores))
                {
                    //find overall score
                    int plThreeFinal = findFinalScore(plThreeScores);
                    label3.Text = Convert.ToString(plThreeFinal);

                }
                else
                {
                    errForm.Show();
                }
            }
            if (PlFourNameLength > 0) {
                //Calculate score for player four
                //input data into an array
                char[] plFourScores;
                plFourScores = new char[21];
                plFourScores[0] = Convert.ToChar(txt411.Text);
                plFourScores[1] = Convert.ToChar(txt412.Text);
                plFourScores[2] = Convert.ToChar(txt421.Text);
                plFourScores[3] = Convert.ToChar(txt422.Text);
                plFourScores[4] = Convert.ToChar(txt431.Text);
                plFourScores[5] = Convert.ToChar(txt432.Text);
                plFourScores[6] = Convert.ToChar(txt441.Text);
                plFourScores[7] = Convert.ToChar(txt442.Text);
                plFourScores[8] = Convert.ToChar(txt451.Text);
                plFourScores[9] = Convert.ToChar(txt452.Text);
                plFourScores[10] = Convert.ToChar(txt461.Text);
                plFourScores[11] = Convert.ToChar(txt462.Text);
                plFourScores[12] = Convert.ToChar(txt471.Text);
                plFourScores[13] = Convert.ToChar(txt472.Text);
                plFourScores[14] = Convert.ToChar(txt481.Text);
                plFourScores[15] = Convert.ToChar(txt482.Text);
                plFourScores[16] = Convert.ToChar(txt491.Text);
                plFourScores[17] = Convert.ToChar(txt492.Text);
                plFourScores[18] = Convert.ToChar(txt401.Text);
                plFourScores[19] = Convert.ToChar(txt402.Text);
                plFourScores[20] = Convert.ToChar(txt403.Text);
                if (isArrayValid(plFourScores))
                {
                    //find overall score
                    int plFourFinal = findFinalScore(plFourScores);
                    label4.Text = Convert.ToString(plFourFinal);

                }
                else
                {
                    errForm.Show();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        
    }
}
