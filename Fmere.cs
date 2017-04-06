using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tpFentreMereFille
{
    public partial class Fmere : Form
    {
        private List<Ffille> lesFilles;
        int numerofille;
        string nomMere;
        

        public Fmere()
        {
            InitializeComponent();
            lesFilles = new List<Ffille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnShow.Click += new EventHandler(btnShow_Click);
            btnNew.Click +=new EventHandler(btnNew_Click_Msg);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
            

            this.Text = nomMere;
            this.nomMere = "Maman";
        }

        void btnClose_Click(object sender, EventArgs e)
        {
            lesFilles[lbFille.SelectedIndex].Close();
        }

        void btnShowDialog_Click(object sender, EventArgs e)
        {
            lesFilles[lbFille.SelectedIndex].ShowDialog();
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            lesFilles[lbFille.SelectedIndex].Hide();
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if ( lbFille.SelectedIndex != -1 )
                lesFilles[lbFille.SelectedIndex].Show();
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            this.numerofille = this.numerofille + 1;
            Ffille nouvelleFille = new Ffille(this.numerofille,this);
            nouvelleFille.TextChanged += new EventHandler(nouvelleFille_TextChanged);
            nouvelleFille.FormClosing += new FormClosingEventHandler(nouvelleFille_FormClosing);
            lesFilles.Add(nouvelleFille);
            lbFille.Items.Add(nouvelleFille.ToString());

        }

        void nouvelleFille_TextChanged(object sender, EventArgs e)
        {
            Ffille f = (Ffille)sender;
            int i = lesFilles.IndexOf(f);
            lbFille.Items.RemoveAt(i);
            lbFille.Items.Insert(i, f.Text);            
        }

        void nouvelleFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ffille f = (Ffille)sender;
            lbFille.Items.RemoveAt(lesFilles.IndexOf(f));
            lesFilles.RemoveAt(lesFilles.IndexOf(f));
            
        }

        void btnNew_Click_Msg(object sender, EventArgs e)
        {
            MessageBox.Show("Une fille a été instancié");
        }

        public string GetNomMere() 
        {
            return this.nomMere;
        }

        //public void MaFilleChangeDeNom(Ffille laFille, string nouveauNom)
        //{
        //    int i = lesFilles.IndexOf(laFille);
        //    lbFille.Items.RemoveAt(i);           
        //    lbFille.Items.Insert(i, laFille.Text);
            
        //}


        

        

        
    }
}
