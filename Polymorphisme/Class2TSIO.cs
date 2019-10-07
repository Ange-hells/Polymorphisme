using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphisme
{
	public partial class Class_2TSIO : Form
	{
		private Eleve nouvelEleve;
		private section uneSection;

		public Class_2TSIO()
		{
			InitializeComponent();
			uneSection = new section();
		}

		private void BT_Insciption_Click(object sender, EventArgs e)
		{
			if ((LastName.Text == "") || (Add.Text == "") || (Name.Text == ""))
			{
				MessageBox.Show("Un ou plusieurs chammps ne sont pas remplis");
			}
			else
			{
				if (BR_Slam.Checked)
				{
					nouvelEleve = new Slam(LastName.Text, Name.Text, Specialiter.Text, BR_Slam.Text);
				}
				else
				{
					nouvelEleve = new Sisr(LastName.Text, Name.Text, Certification.Text, BR_Sisr.Text);
				}
				uneSection.ajouterEleves(nouvelEleve);
				LastName.Text = "";
				Name.Text = "";
				Add.Text = "";
				Specialiter.Text = "";
				Certification.Text = "";

			}
		}

		private void BT_Voir_Click(object sender, EventArgs e)
		{
			ListViewItem lv_item = new ListViewItem();
			listwiew.Items.Clear();
			if (CB_Specialite.SelectedItem.ToString() == "Slam")
			{
				IEnumerable<Eleve> req;
				if (TB_Recherche.Text != "")
				{
					req = from eleve in uneSection.getlesEleves().OfType<Slam>()
							where eleve.Nom.StartsWith(TB_Recherche.Text)
							select eleve;
				}
				else
				{
					req = from eleve in uneSection.getlesEleves().OfType<Slam>()
							select eleve;
				}

				foreach (Eleve eleve in req.ToList())
				{
					lv_item = listwiew.Items.Add(eleve.Numero.ToString());
					lv_item.SubItems.Add(eleve.Nom);
					lv_item.SubItems.Add(eleve.Prenom);
					lv_item.SubItems.Add(eleve.EditerOption());
				}
			}
			else if (CB_Specialite.SelectedItem.ToString() == "Sisr")
			{
				IEnumerable<Eleve> req;
				if (TB_Recherche.Text != "")
				{
					req = from eleve
								in uneSection.getlesEleves().OfType<Sisr>()
							where eleve.Nom.StartsWith(TB_Recherche.Text)
							select eleve;
				}
				else
				{
					req = from eleve
								in uneSection.getlesEleves().OfType<Sisr>()
							select eleve;
				}

				foreach (Eleve eleve in req)
				{
					lv_item = listwiew.Items.Add(eleve.Numero.ToString());
					lv_item.SubItems.Add(eleve.Nom);
					lv_item.SubItems.Add(eleve.Prenom);
					lv_item.SubItems.Add(eleve.EditerOption());
				}
			}
			else
			{
				IEnumerable<Eleve> req;
				if (TB_Recherche.Text != "")
				{
					req = from eleve in uneSection.getlesEleves()
							where eleve.Nom.StartsWith(TB_Recherche.Text)
							select eleve;
				}
				else
				{
					req = from eleve in uneSection.getlesEleves()
							select eleve;
				}

				foreach (Eleve eleve in req)
				{
					lv_item = listwiew.Items.Add(eleve.Numero.ToString());
					lv_item.SubItems.Add(eleve.Nom);
					lv_item.SubItems.Add(eleve.Prenom);
					lv_item.SubItems.Add(eleve.EditerOption());
				}
			}//end else
		}//end void click
	}//end class
}