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
    public partial class Ffille : Form
    {

        int numeroFille;
        Fmere maMere;
        
        

        

        public Ffille(int numeroFille, Fmere maMere)
        {
            InitializeComponent();
            this.numeroFille = numeroFille;
            this.maMere = maMere;
            this.Text = this.ToString();
            btnMamere.Click += new EventHandler(btnMamere_Click);
            btnChanger.Click += new EventHandler(btnChanger_Click);
            this.Load += new EventHandler(Ffille_Load);
            
                                            
        }

        
       

        void btnChanger_Click(object sender, EventArgs e)
        {
            this.Text = tbNom.Text; 
            // plus besoin d'appeler MafilleChangeDeNom grace aux deuxieme cas ou la mere sabonne a l'évenement textchanged de sa fille instancié 
            //maMere.MaFilleChangeDeNom(this, this.Text);
        }

        void Ffille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement load sur la fenetre"+this.numeroFille);
        }

        void btnMamere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maMere.GetNomMere());
        }

        public override string ToString()
        {
            return String.Format("n°{0} : {1}", this.numeroFille,this.Text);
        }

        public int GetNumFille()
        {
            return this.numeroFille;
        }

        //annule l'evenement Close et le change en Hide()
 
        //private void Ffille_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        e.Cancel = true;
        //        this.Hide();
        //    }
        //}


        





        
    }
}
