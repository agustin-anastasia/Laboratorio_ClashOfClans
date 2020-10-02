using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3___2018
{
    public partial class Form2 : Form
    {
        public Form2(String player)
        {
            InitializeComponent();
            Aldea a = Aldea.GetInstancia();
            a.Nombre = player;
            label1.Text = a.Nombre;

            Ayuntamiento ay = new Ayuntamiento();
            a.Constructor(ay);
            Actualizar();
        }
        private void toolStripMenuItem_Cañon_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Cañones()));
            Actualizar();
        }
        private void Actualizar()
        {
            Aldea a = Aldea.GetInstancia();
            a.ActualizarTopesRecursos();
            // Cantidades
            lblOro.Text = Convert.ToString(a.CantidadOro);
            lblElixir.Text = Convert.ToString(a.CantidadElixir);
            lblElixirN.Text = Convert.ToString(a.CantidadElixirN);
            labelCantTropa.Text = Convert.ToString(a.CantidadTropas);
            // Capacidades
            lblOroMax.Text = Convert.ToString("/" + a.CapacidadOro);
            lblElixirMax.Text = Convert.ToString("/" + a.CapacidadElixir);
            lblElixirNMax.Text = Convert.ToString("/" + a.CapacidadElixirN);
            labelMaxTropa.Text = Convert.ToString("/" + a.CapacidadTropas);

            dataGridEdificios.DataSource = null;
            dataGridEdificios.DataSource = a.listaEdificiosAldea;
            // Si hay un cuartel, muestra en el menú, el botón de crear tropas y el datagrid de las tropas
            if (a.HayCuartel)
            {
                toolStripMenuItem30.Visible = true;
                dataGridTropas.Visible = true;
                labelTropas.Visible = true;
            }
            dataGridTropas.DataSource = null;
            dataGridTropas.DataSource = a.listaTropasAldea;
            // Se muestra el botón para poder crear tropas oscuras, sólo si existe un cuartel oscuro.
            if (a.HayCuartelOscuro)
            {
                toolStripMenuItem44.Visible = true;
            }

            if (a.HayRecolectorOro)
            {
                btnRecOro.Visible = true;
            }
            if (a.HayRecolectorElixir)
            {
                btnRecElixir.Visible = true;
            }

            if (a.HayRecolectorElixirN)
            {
                btnRecElixirN.Visible = true;
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e) //Comprar mina de oro
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new MinaOro()));
            Actualizar();
        }

        private void MenuArquera_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Arquera()));
            Actualizar();
        }

        private void MenuBarbaro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Barbaro()));
            Actualizar();
        }

        private void MenuGigante_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Gigante()));
            Actualizar();
        }

        private void MenuMago_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Mago()));
            Actualizar();
        }

        private void MenuDuende_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Duende()));
            Actualizar();
        }

        private void MenuGlobo_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Globo()));
            Actualizar();
        }

        private void MenuPekkas_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Pekka()));
            Actualizar();
        }

        private void MenuDragon_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Dragon()));
            Actualizar();
        }

        private void MenuEsqueleto_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Esqueleto()));
            Actualizar();
        }

        private void MenuDragonBebe_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new DragonBebe()));
            Actualizar();
        }

        private void MenuCurandera_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Curandera()));
            Actualizar();
        }

        private void MenuMinero_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Minero()));
            Actualizar();
        }

        private void MenuEsbirro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Esbirro()));
            Actualizar();
        }

        private void MenuMontaPuerco_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Montapuercos()));
            Actualizar();
        }

        private void MenuValkiria_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Valkiria()));
            Actualizar();
        }

        private void MenuGolem_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Golem()));
            Actualizar();
        }

        private void MenuBruja_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Bruja()));
            Actualizar();
        }

        private void MenuLavas_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Lavas()));
            Actualizar();
        }

        private void MenuLanzaroca_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new LanzaRoca()));
            Actualizar();
        }

        private void MenuRey_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Rey()));
            Actualizar();
        }

        private void MenuReina_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Reina()));
            Actualizar();
        }

        private void MenuWarden_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor2(new Warden()));
            Actualizar();
        }

        private void MenuRecolectorElixirRojo_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new RecolectoraElixir()));
            Actualizar();
        }

        private void MenuRecolectorElixirOscuro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new RecolectoraElixirN()));
            Actualizar();
        }

        private void MenuAlmacenamientoRojo_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new AlmacenElixir()));
            Actualizar();
        }

        private void MenuAlmacenamientoElixirOscuro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new AlmacenElixirN()));
            Actualizar();
        }

        private void MenuAlmacenamientoOro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new AlmacenOro()));
            Actualizar();
        }

        private void MenuAlmacenamientoCastillo_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Castillo()));
            Actualizar();
        }

        private void MenuAlmacenamientoCampamento_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Campamento()));
            Actualizar();
        }

        private void MenuCuartel_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Cuartel()));
            Actualizar();
        }

        private void MenuCuartelOscuro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new CuartelOscuro()));
            Actualizar();
        }

        private void MenuAntiaereo_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Antiaereos()));
            Actualizar();
        }

        private void MenuTorreArquera_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new TorreArquera()));
            Actualizar();
        }

        private void MenuTorreMago_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new TorreDeMagos()));
            Actualizar();
        }

        private void MenuTorreInfierno_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new TorreInfierno()));
            Actualizar();
        }

        private void MenuTesla_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Tesla()));
            Actualizar();
        }

        private void MenuBallesta_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Ballestas()));
            Actualizar();
        }

        private void MenuMuro_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Muros()));
            Actualizar();
        }

        private void MenuAguila_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            MessageBox.Show(a.Constructor(new Aguila()));
            Actualizar();
        }

        private void btnRecOro_Click(object sender, EventArgs e)

        {
            Aldea a = Aldea.GetInstancia();
            if (a.CantidadOro + 100 <= a.CapacidadOro)
            {
                a.CantidadOro += 100;
                Actualizar();
            }
            else
            {
                a.CantidadOro = a.CapacidadOro;
                Actualizar();
            }
        }

        private void btnRecElixir_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            if (a.CantidadElixir +100 <= a.CapacidadElixir)
            {
                a.CantidadElixir += 100;
                Actualizar();
            }
            else
            {
                a.CantidadElixir = a.CapacidadElixir;
                Actualizar();
            }
        }

        private void btnRecElixirN_Click(object sender, EventArgs e)
        {
            Aldea a = Aldea.GetInstancia();
            if (a.CantidadElixirN + 100 <= a.CapacidadElixirN)
            {
                a.CantidadElixirN += 100;
                Actualizar();
            }
            else
            {
                a.CantidadElixirN = a.CapacidadElixirN;
                Actualizar();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}