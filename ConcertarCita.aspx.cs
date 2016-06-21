using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using objMiCita1 = Practica08_ControlesB.AppCode.ClsCitaBLF;
using Practica08_ControlesB.AppCode;


namespace Practica08_ControlesB.Demo
{
    public partial class ConcertarCita : System.Web.UI.Page
    {
        //AppCode.ClsCitaBLF objMiCita1 = new AppCode.ClsCitaBLF();
        ClsCitaBLF objMiCita1 = new ClsCitaBLF();
        protected void Page_Load(object sender, EventArgs e)        {        }

        protected void btnMostrar_Click(object sender, EventArgs e)        {
            objMiCita1 = (ClsCitaBLF)(Session["MiObjSalvado"]);
            lblEstado.Text = objMiCita1.mostrarDatos();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)        {
            lblEstado.Text = objMiCita1.agregarDatos(txtNombre.Text, ddlProfesor.SelectedValue, ddlDia.SelectedValue, rblHora.SelectedValue, txtAsunto.Text);
            Session["MiObjSalvado"] = objMiCita1;
            btnMostrar.Enabled = true;
        }

        protected void btnRestablecer_Click(object sender, EventArgs e)        {
            CleanControl(this.Controls);
            btnMostrar.Enabled = false;
        }

        public void CleanControl(ControlCollection controles)        {
            foreach (Control control in controles)            {
                if (control is TextBox)
                    ((TextBox)control).Text = string.Empty;
                else if (control is DropDownList)
                    ((DropDownList)control).ClearSelection();
                else if (control is RadioButtonList)
                    ((RadioButtonList)control).ClearSelection();
                else if (control is CheckBoxList)
                    ((CheckBoxList)control).ClearSelection();
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
                else if (control is Label)
                    ((Label)control).Text = string.Empty;
                else if (control.HasControls())
                    CleanControl(control.Controls); //detectando mas controles
            }
        }

    }//FIN CLASS
}//FIN NAME