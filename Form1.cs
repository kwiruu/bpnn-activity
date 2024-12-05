using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bnn_activity
{

    public partial class Form1 : Form
    {
        int[,] orModel2Inputs = new int[,] { { 0, 0, 0 }, { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        int[,] andModel4Inputs = new int[,] {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 0 },
                { 0, 0, 1, 1, 0 },
                { 0, 1, 0, 0, 0 },
                { 0, 1, 0, 1, 0 },
                { 0, 1, 1, 0, 0 },
                { 0, 1, 1, 1, 0 },
                { 1, 0, 0, 0, 0 },
                { 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0 },
                { 1, 0, 1, 1, 0 },
                { 1, 1, 0, 0, 0 },
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 0, 0 },
                { 1, 1, 1, 1, 1 }
            };

        NeuralNet nn;
        int[,] operation;


        public Form1()
        {
            InitializeComponent();

        }

        private void resetNeuralNet()
        {
            nn = new NeuralNet(4, 4, 1);
            operation = andModel4Inputs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetNeuralNet();
        }

        private void setNetwork()
        {
            for (int i = 0; i < operation.GetLength(0); i++)
            {
                for (int j = 0; j < operation.GetLength(1) - 1; j++)
                {
                    nn.setInputs(j, operation[i, j]);
                }
                nn.setDesiredOutput(0, operation[i, operation.GetLength(1) - 1]);
                nn.learn();
            }
        }

        private void train(int epochs)
        {
            resetNeuralNet();
            for (int i = 0; i < epochs; i++)
            {
                setNetwork();
            }
        }

        private int findMinEpochs()
        {
            int l = 0, r = 100000;
            double errorThreshold = 0.01;

            while (l < r)
            {
                int m = (l + r) / 2;
                train(m);

                if (getError() < errorThreshold)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            train(Convert.ToInt32(epochTextBox.Text));
        }

        private double getError()
        {
            double errorSum = 0;
            for (int i = 0; i < operation.GetLength(0); i++)
            {
                for (int j = 0; j < operation.GetLength(1) - 1; j++)
                {
                    nn.setInputs(j, operation[i, j]);
                }
                nn.run();
                errorSum += Math.Abs(nn.getOuputData(0) - operation[i, operation.GetLength(1) - 1]);
            }
            return errorSum / operation.GetLength(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();

            outputBox.Text = "" + nn.getOuputData(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bestEpoch = findMinEpochs();
            MessageBox.Show("(Estimated using Binary Search) Best epoch: " + bestEpoch);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double error = getError();
            MessageBox.Show("Error: " + error);
        }
    }
}