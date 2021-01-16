using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOopPractise
{
    public partial class AsyncAwaitThread : Form
    {

        //Links:
        //https://www.youtube.com/watch?v=C5VhaxQWcpE
        //https://www.youtube.com/watch?v=SgHYVPKJRX8


        public AsyncAwaitThread()
        {
            InitializeComponent();
        }

        int characterCount = 0;

        private int CountCharacter()
        {
            int count = 0;

            using (StreamReader reader = new StreamReader("D:\\REPO\\SAYED\\file.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            };

            return count;
        }

        private  void startThreadBtn_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(() => 
            {
                characterCount = CountCharacter();
                Action action = () =>SetLabelTextCount();
                this.BeginInvoke(action);

            });
            thread.Start();
            countLbl.Text = "Processing File.. with thread.";

        }


        private void SetLabelTextCount()
        {
            countLbl.Text = characterCount + " character in file";
        }


        private async void startTaskBtn_ClickAsync(object sender, EventArgs e)
        {
            Task<int> counting = new Task<int>(CountCharacter);
            counting.Start();

            countLbl.Text = "Processing File... with task.";
            int count = await counting;
            countLbl.Text = count + " character found";
        }
    }
}
