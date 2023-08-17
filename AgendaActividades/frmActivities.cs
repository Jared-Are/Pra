using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActividades
{
    public partial class frmActivities : Form
    {
        private bool _HasChange, _isNewAct;


        public frmActivities()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            this.lstAct.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnAdd.Enabled = true;
            this.btnCancel.Enabled = false;
            this.btnSave.Enabled = false;
            this.txtActiv.Enabled = false;

            //enable/disable the listbox based on number items
            this.lstAct.Enabled = this.lstAct.Items.Count > 0;
            this.lstAct.SelectedIndex = -1;

            _HasChange = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.addNewAct();
        }

        private void addNewAct()
        {
            if (_HasChange)
            {
                if (MessageBox.Show("Guardar cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   if( !this.SaveChanges())
                    {
                        return;
                    }
                }
             }
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnAdd.Enabled = false;

            txtActiv.Enabled = true;
            txtActiv.Clear();
            txtActiv.Focus();

            _isNewAct = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveChanges();

        }

      

        private void frmActivities_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Guaardar cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (!this.SaveChanges())
                {
                    e.Cancel = true;
                    return;
                }
            }
            else if (r == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void Delete()
        {
            if (MessageBox.Show("Esta seguro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(lstAct.SelectedItems.Count >= 0 && lstAct.SelectedIndex < lstAct.Items.Count)
                {
                    this.lstAct.Items.RemoveAt(lstAct.SelectedIndex);
                    Reset();
                }
            }
        }

        private void txtActiv_TextChanged(object sender, EventArgs e)
        {
            _HasChange = true;
        }

        private bool SaveChanges()
        {
            if(txtActiv.Text.Length == 0)
            {
                MessageBox.Show("Debe escibir un nombre para la actividad", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(_isNewAct)
            {
                this.lstAct.Items.Add(txtActiv.Text);
                this.Reset();
            }

            else
            {
                this.lstAct.Items[lstAct.SelectedIndex] = txtActiv.Text;
                MessageBox.Show("");
            }
            return true;
        }
    }

 }

