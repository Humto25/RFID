using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    public partial class Form1 : Form
    {
        Timer timerActualizacion = new Timer();
        private string DataSerIn;


        public Form1()
        {
            InitializeComponent();
            cmbBaudios.Items.Add(9600);
            cmbBaudios.Items.Add(19200);
            cmbBaudios.Items.Add(38400);
            cmbBaudios.Items.Add(57600);
            cmbBaudios.Items.Add(115200);
            cmbBaudios.Items.Add(2400);
            cmbBaudios.Items.Add(4800);
            cmbBaudios.Items.Add(14400);
            cmbBaudios.Items.Add(230400);
            timerActualizacion.Interval = 1000; 
            timerActualizacion.Tick += (sender, e) => ActualizarLabels();
            timerActualizacion.Start();

        }

        private void ConectarArduino()
        {
            try
            {
                serialPort.PortName = cmbPuerto.Text;
                serialPort.BaudRate = int.Parse(cmbBaudios.Text);
                serialPort.Open();
                lblStatus.Text = "Estado de conexión: Conectado";
                btnConectar.Text = "Desconectar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el puerto. Asegúrate de que el Arduino esté bien conectado y de seleccionar el puerto correcto.{Environment.NewLine}Error:{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarLabels()
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("h:mm tt");
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void DesconectarArduino()
        {
            try
            {
               serialPort.Close();
                lblStatus.Text = "Estado de conexión: Desconectado";
                btnConectar.Text = "Conectar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cerrar el puerto: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MoverPictureBoxALaIzquierdaDelBoton(Button boton)
        {
           
            int nuevaPosicionX = boton.Left - PbFlecha.Width;         
            int nuevaPosicionY = boton.Top + (boton.Height - PbFlecha.Height) / 2;          
            PbFlecha.Location = new System.Drawing.Point(nuevaPosicionX, nuevaPosicionY);
        }



        private void btnConexionicon_Click(object sender, EventArgs e)
        {
            MoverPictureBoxALaIzquierdaDelBoton(btnConexionicon);
        }

        private void btnDatosusuarioicon_Click(object sender, EventArgs e)
        {
            MoverPictureBoxALaIzquierdaDelBoton(btnDatosusuarioicon);
        }

        private void btnRegistroicon_Click(object sender, EventArgs e)
        {
            MoverPictureBoxALaIzquierdaDelBoton(btnRegistroicon);
        }

        private void btnPuerto_Click(object sender, EventArgs e)
        {
            string[] myport = SerialPort.GetPortNames();
            cmbPuerto.Items.AddRange(myport);
            cmbPuerto.SelectedIndex = 0;
            btnConectar.Enabled = true;
            cmbPuerto.DroppedDown = true;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataSerIn = serialPort.ReadLine();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
            {
                ConectarArduino();
                pbStatus.Image = Properties.Resources.Connected; // Cambiar imagen a Connected
                lblStatus.Text = "Estado de conexión: Conectado"; // Cambiar texto a Conectado
            }
            else
            {
                DesconectarArduino();
                pbStatus.Image = Properties.Resources.Disconnect; // Cambiar imagen a Disconnected
                lblStatus.Text = "Estado de conexión: Desconectado"; // Cambiar texto a Desconectado
            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
    
}
