using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba;
using UberFrba.Model;
using UberFrba.Abm_Automovil;
using UberFrba.Abm_Persona;
using UberFrba.Abm_usuario;

namespace UberFrba
{
    public partial class MenuPrincipal : FormBase
    {
        public static ToolStripMenuItem[] controles = new ToolStripMenuItem[] { };
        public static List<ToolStripMenuItem> allControles = new List<ToolStripMenuItem>();
        public static ToolStrip strip = null;

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void FormBase_Load(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.mostrar(this);
            this.menuStrip1.Visible = false;
            controles = new ToolStripMenuItem[] { altaAutomovil, bajaAutomovil, modificacionAutomovil, altaChofer, bajaChofer, modificacionChofer, altaCliente, bajaCliente, modificacionCliente, facturacion, listadoEstadistico, registroDeViajes, rendicionDeViajes, altaRol, bajaRol, modificacionRol, altaTurno, bajaTurno, modificacionTurno, cambiarPassword };

            foreach (ToolStripMenuItem tool in this.menuStrip1.Items/*Controls.OfType<ToolStripMenuItem>()*/)
                allControles.Add(tool);
            allControles.Remove(cerrarSesiònToolStripMenuItem);
            allControles.Remove(salirToolStripMenuItem);

            strip = this.menuStrip1; 
        }

        private bool noPuedeIngresar(int idFun)
        {
            if (!puedeIngresar(idFun))
            {
                Mensaje_Error("No posee acceso a esta funcionalidad", "Funcionalidad inaccesible");
                return true;
            }
            else
                return false;
        }

        private bool puedeIngresar(int idFun)
        {
            if (Globals.tieneFuncionalidad(idFun))
            {
                return true;//Puede acceder
            }
            return false;
        }

        private void registroDeViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(noPuedeIngresar(12)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
               Registro_Viajes.RegistrarViaje registrarViaje = new Registro_Viajes.RegistrarViaje();
               registrarViaje.mostrar(this);
               //Abm_Persona.SeleccionDePersona seleccionPersona = new Abm_Persona.SeleccionDePersona(new Registro_Viajes.RegistrarViaje(), 2);
               //seleccionPersona.mostrar(this);


        }

        private void altaAutomovil_click(object sender, EventArgs e) 
        {
            if (noPuedeIngresar(1)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Automovil.AltaAutomovil altaAutomovil = new Abm_Automovil.AltaAutomovil();
            altaAutomovil.mostrar(this);
        }

        private void bajaAutomovil_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(2)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Automovil.BajaAutomovil bajaAutomovil = new Abm_Automovil.BajaAutomovil();
            bajaAutomovil.mostrar(this);
        }

        private void modificacionAutomovil_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(3)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Automovil.ModificacionAutomovil modificacionAutomovil = new Abm_Automovil.ModificacionAutomovil();
            modificacionAutomovil.mostrar(this);
        }

        private void altaChofer_click(object sender, EventArgs e)
        {

            if (noPuedeIngresar(4)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.AltaPersona altaChofer = new Abm_Persona.AltaPersona(2);
            altaChofer.mostrar(this);
        }

        private void bajaChofer_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(5)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.SeleccionDePersona seleccionPersona = new Abm_Persona.SeleccionDePersona(new Abm_Persona.BajaPersona(2),2);
            seleccionPersona.mostrar(this);
        }

        private void modificacionChofer_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(6)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.SeleccionDePersona seleccionPersona = new Abm_Persona.SeleccionDePersona(new Abm_Persona.ModificacionPersona(2),2);
            seleccionPersona.mostrar(this);
        }

        private void altaCliente_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(7)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.AltaPersona altaCliente = new Abm_Persona.AltaPersona(3);
            altaCliente.mostrar(this);
        }

        private void bajaCliente_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(8)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.SeleccionDePersona seleccionPersona = new Abm_Persona.SeleccionDePersona(new Abm_Persona.BajaPersona(3),3);
            seleccionPersona.mostrar(this);
        }

        private void modificacionCliente_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(8)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Persona.SeleccionDePersona seleccionPersona = new Abm_Persona.SeleccionDePersona(new Abm_Persona.ModificacionPersona(3),3);
            seleccionPersona.mostrar(this);
        }

        private void altaRol_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(14)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Rol.AltaRol altaRol = new Abm_Rol.AltaRol();
            altaRol.mostrar(this);
        }

        private void bajaRol_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(15)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Rol.BajaRol bajaRol = new Abm_Rol.BajaRol();
            bajaRol.mostrar(this);
        }

        private void modificacionRol_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(16)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Rol.ModificacionRol modificacionRol = new Abm_Rol.ModificacionRol();
            modificacionRol.mostrar(this);
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.username == "")
            {
                Mensaje_Error("¡Todavía no inicio sesión!", "Inicie una sesión");
                return;
            }
            var mensaje = Mensaje_Pregunta("¿Desea cerrar la sesión actual: " + Globals.username + "?", "Cerrar sesión");
            if (mensaje == DialogResult.No) return;

            Globals.cerrarSesion();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Login.Login login = new Login.Login();
            login.mostrar(this);
            this.menuStrip1.Visible = false;
        }

        private static void hideControls()
        {
            foreach (ToolStripMenuItem control in allControles)
                control.Visible = false;
        }

        public static void showControls()
        {
            strip.Visible = true;
            hideControls();
            for (int i = 0; i < controles.Count(); i++)
            {
                if (Globals.tieneFuncionalidad(i + 1))
                {
                    controles[i].Visible = true;
                    if (controles[i].OwnerItem != null)
                        controles[i].OwnerItem.Visible = true;     
                }
            }
        }


        private void listadoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(11)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Listado_Estadistico.ListadoEstadistico listadoEstadistico = new Listado_Estadistico.ListadoEstadistico();
            listadoEstadistico.mostrar(this);
        }

        private void facturacionToolStripMenuItem_click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(10)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            //Facturacion.Facturar facturar = new Facturacion.Facturar();
            //facturar.mostrar(this);   
            Abm_Persona.SeleccionPersonaActiva seleccionPersonaActiva = new Abm_Persona.SeleccionPersonaActiva(new Facturacion.Facturar(), 3);
            seleccionPersonaActiva.mostrar(this);
        }

        private void rendicionDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(13)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            //Rendicion_Viajes.RendirViaje rendirViaje = new Rendicion_Viajes.RendirViaje();
            //rendirViaje.mostrar(this); 
            Abm_Persona.SeleccionPersonaActiva seleccionPersonaActiva = new Abm_Persona.SeleccionPersonaActiva(new Rendicion_Viajes.RendirViaje(), 2);
            seleccionPersonaActiva.mostrar(this);
        }

        private void altaTurno_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(17)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Turno.AltaTurno altaTurno = new Abm_Turno.AltaTurno();
            altaTurno.mostrar(this);    
        }

        private void bajaTurno_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(18)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Turno.BajaTurno bajaTurno = new Abm_Turno.BajaTurno();
            bajaTurno.mostrar(this);    
        }

        private void modificacionTurno_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(19)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_Turno.ModificacionSeleccionTurno modificacionTurno = new Abm_Turno.ModificacionSeleccionTurno(new Abm_Turno.ModificacionTurno());
            modificacionTurno.mostrar(this);     
        }

        private void cambiarPassword_Click(object sender, EventArgs e)
        {
            if (noPuedeIngresar(20)) return;
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Abm_usuario.CambiarPassword cambiarPassword = new Abm_usuario.CambiarPassword();
            cambiarPassword.mostrar(this);   
        }
    }
}
