using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCCFoodTrackerNeo
{
    
    public partial class userFood : UserControl
    {
        public userFood()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int foodId { get; set; }
        public string foodintPrice { get; set; }
        public string foodCategory { get; set; }
        public string foodName
        {
            get { return foodNamelbl.Text; }
            set { foodNamelbl.Text = value; }
        }
        public Image foodPicture
        {
            get { return foodPicturelbl.Image; }
            set { foodPicturelbl.Image = value; }
        }

        private void foodPicturelbl_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

    }
}
