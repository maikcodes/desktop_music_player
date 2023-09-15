using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinAppMyMusic
{
    public partial class Form1 : Form
    {
        bool play = true;
        MemoryStream MVP;
        string[] archivosmp3;
        string[] rutas;
        int posActual, posultima, posSiguiente, clickb;
        bool alea, bu, controlF;

        public Form1()
        {
            InitializeComponent();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            
            if (clickb == 0)
            {
                AGMusic();
                clickb = 0;
            }
            else
            {
                ListBMusica.Items.Clear();
                Array.Clear(archivosmp3, 0, archivosmp3.Length);
                Array.Clear(rutas, 0, rutas.Length);
                AGMusic();
            }
        }

        private void ListBMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnteriorCarat();

            TagLib.File Repro = TagLib.File.Create(rutas[ListBMusica.SelectedIndex]);
            var titlea = Repro.Tag.Title;
            var descri = Repro.Properties.Description;
            LblTitulo.Text = titlea;
            LblDescription.Text = descri;

            SiguienteCarat(ListBMusica.SelectedIndex);
            MemoryStream ms = new MemoryStream(Repro.Tag.Pictures[0].Data.Data);

            MVP = ms;// guardando la caratula anterior
            System.Drawing.Image pic = System.Drawing.Image.FromStream(ms);
            pbxCaratula.Image = pic;


            Reproductor.URL = rutas[ListBMusica.SelectedIndex];
        }

        private void AGMusic()
        {
            clickb++;
            OpenFileDialog Busqueda = new OpenFileDialog();
            Busqueda.Multiselect = true;
            Busqueda.Filter = "Seleccione música|*.mp3";
            if (Busqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivosmp3 = Busqueda.SafeFileNames;
                rutas = Busqueda.FileNames;

                MusicINListB();
                ReproudcirMusic(0);

            }
            else
            {
                MessageBox.Show("No se seleccionaron músicas", "Aviso");
            }
        }

        private void MusicINListB()
        {
            for (int i = 0; i < rutas.Length; i++)
            {
                EscribirList(i);
            }
        }

        private void ReproudcirMusic(int num)
        {
            Reproductor.URL = rutas[num];
            TagLib.File filet = TagLib.File.Create(rutas[num]);
            var titlea = filet.Tag.Title;
            var descri = filet.Properties.Description;
            LblTitulo.Text = titlea;
            LblDescription.Text = descri;
            ListBMusica.SelectedIndex = num;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
            play = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                switch (play)
                {
                    case true:
                        Reproductor.Ctlcontrols.pause();
                        this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                        play = false;
                        break;
                    case false:
                        Reproductor.Ctlcontrols.play();
                        this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                        play = true;
                        break;
                }
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                mcTrackBarTiempo.Value = 0;
                timer1.Stop();
                Reproductor.Ctlcontrols.stop();
                this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                play = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActulizarDatosTrack();
            mcTrackBarTiempo.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            macTrackBar1.Value = Reproductor.settings.volume;
        }

        private void AnteriorCarat()
        {
            if (pbxAnterior.Image == null)
            {
                pbxAnterior.Image = WinAppMyMusic.Properties.Resources.MuLogo;
            }
            else
            {
                System.Drawing.Image pA = System.Drawing.Image.FromStream(MVP);
                pbxAnterior.Image = pA;
            }
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = macTrackBar1.Value;
        }

        private void mcTrackBarTiempo_ValueChanged(object sender, decimal value)
        {
            if (comprobarListBox())
            {
                mcTrackBarTiempo.Maximum = (int)Reproductor.currentMedia.duration;
                if (mcTrackBarTiempo.Value != (int)Reproductor.Ctlcontrols.currentPosition)
                {
                    Reproductor.Ctlcontrols.currentPosition = mcTrackBarTiempo.Value;
                }
                else
                {
                    if (mcTrackBarTiempo.Value == Reproductor.Ctlcontrols.currentPosition)
                    {
                        Verficar();
                    }
                }
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActulizarDatosTrack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                controlF = true;
                this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                SigCancion();
            }
            
        }

        private void SiguienteCarat(int Npos)
        {
            posActual = Npos;
            posultima = posActual;
            posSiguiente = posActual + 1;

            if ((posActual == rutas.Length) && (posultima == 0))//verificar si no es la unica cancion 
            {
                pbxSiguiente.Image = WinAppMyMusic.Properties.Resources.MuLogo;
            }
            else
            {
                Caratula();
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                controlF = true;
                this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                AntCancion();
            }
            
        }

        private void Caratula()
        {
            if (posSiguiente == rutas.Length)//reporduciendo la ultima cacnion de la lista
            {
                pbxSiguiente.Image = WinAppMyMusic.Properties.Resources.MuLogo;
            }
            else
            {
                TagLib.File Repro1 = TagLib.File.Create(rutas[posSiguiente]);
                MemoryStream ms = new MemoryStream(Repro1.Tag.Pictures[0].Data.Data);
                System.Drawing.Image pic = System.Drawing.Image.FromStream(ms);
                pbxSiguiente.Image = pic;
            }
        }

        public void ActulizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mcTrackBarTiempo.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else
            {
                if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    timer1.Stop();
                }
                else
                {
                    if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
                    {
                        timer1.Stop();
                        mcTrackBarTiempo.Value = 0;
                    }
                }
            }
        }

        public void SigCancion()
        {
            //ListBMusica.SelectedIndex
            if ( posSiguiente == rutas.Length)//reporduciendo la ultima cacnion de la lista
            {
                Reproductor.URL = rutas[0];
                TagLib.File filet = TagLib.File.Create(rutas[0]);
                var titlea = filet.Tag.Title;
                var descri = filet.Properties.Description;
                LblTitulo.Text = titlea;
                LblDescription.Text = descri;
                ListBMusica.SelectedIndex = 0;
            }
            else
            {
                Reproductor.URL = rutas[posActual+1];
                TagLib.File filet = TagLib.File.Create(rutas[posActual+1]);
                var titlea = filet.Tag.Title;
                var descri = filet.Properties.Description;
                LblTitulo.Text = titlea;
                LblDescription.Text = descri;
                ListBMusica.SelectedIndex = posActual+1;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                if (alea == true)
                {
                    alea = false;
                    iconButton1.IconColor = Color.White;
                }
                else
                {
                    alea = true;
                    iconButton1.IconColor = Color.Gray;
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (comprobarListBox())
            {
                if (bu == true)
                {
                    bu = false;
                    iconButton2.IconColor = Color.White;
                }
                else
                {
                    bu = true;
                    iconButton2.IconColor = Color.Gray;
                }

            }
        }

        public void AntCancion()
        {
            if (posActual == 0)//reporduciendo la ultima cacnion de la lista
            {
                posSiguiente++;
                Reproductor.URL = rutas[0];
                TagLib.File filet = TagLib.File.Create(rutas[0]);
                var titlea = filet.Tag.Title;
                var descri = filet.Properties.Description;
                LblTitulo.Text = titlea;
                LblDescription.Text = descri;
                ListBMusica.SelectedIndex = 0;
            }
            else
            {
                //Retrocediendo una variable en la posicion siguinete para Reproducir la cancion anterior
              
                Reproductor.URL = rutas[posActual-1];
                TagLib.File filet = TagLib.File.Create(rutas[posActual-1]);
                var titlea = filet.Tag.Title;
                var descri = filet.Properties.Description;
                LblTitulo.Text = titlea;
                LblDescription.Text = descri;
                ListBMusica.SelectedIndex = posActual-1;
            }
        }

        private void pbxCaratula_Click(object sender, EventArgs e)
        {

        }

        private void pbxSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void EscribirList(int n)
        {
            TagLib.File file = TagLib.File.Create(rutas[n]);
            var title = file.Tag.Title;
            var artist = file.Tag.FirstAlbumArtist;
            var minut = file.Properties.Duration.Minutes;
            var second = file.Properties.Duration.Seconds;

            if ((minut < 10)&&(second<10))
            {
                ListBMusica.Items.Add(title+ " "+ artist + " " + "0" + minut + " : " + "0" + second);
            }
            else
            {
                if(minut < 10)
                {
                    ListBMusica.Items.Add(title + " " + artist + " " + "0" + minut + " : " + second);
                }
                else
                {
                    if (second < 10)
                    {
                        ListBMusica.Items.Add(title + " "  + artist+ " " + minut + " : " + "0"+ second);
                    }
                    else
                    {
                        ListBMusica.Items.Add(title + " " + artist + " "  + minut + " : "+ second);
                    }
                }
            }
        }

        private void ReproducirCOL_BUQ_AL()
        {
            switch (BotonesPresionados())
            {
                case 'a':              
                    int random = new Random().Next(0, rutas.Length);
                    ReproudcirMusic(random);
                    break;
                case 'b':
                    ReproudcirMusic(posActual);
                    break;
                case 'c':
                    SigCancion();
                    break;
            }

        }

        private char BotonesPresionados()
        {
            if (alea == true)
            {
                return 'a';
            }
            else
            {
                if (bu == true)
                {
                    return 'b';
                }
                else
                {
                    return 'c';
                }
            }
        }

        private void Verficar()
        {
            if (controlF == false)
            {
                ReproducirCOL_BUQ_AL();
            }
            else
            {
                controlF = false;
            }
        }

        public bool comprobarListBox()
        {
            if (ListBMusica.Items.Count > 0)
                return true;

            return false;
        }
    }
}
