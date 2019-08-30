using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorTareas
{
    class ListaProcesos
    {
        // Instancia.
        private List<Procesos> pro = new List<Procesos>();

        // Constructor.
        public ListaProcesos() { }

        // Métodos get y set.
        public List<Procesos> ProcesosLista
        {
            get { return pro; }
            set { pro = value; }
        }

        // Ingresar datos a la lista.
        public void InsertarLista(Procesos datos)
        {
            ProcesosLista.Add(datos);
        }

        // Mostrar la lista.
        public List<Procesos> MostrarLista()
        {
            return ProcesosLista;
        }

        // Buscar datos en la lista.
        public bool BuscarLista(int id)
        {
            bool find = false;
            foreach (var data in ProcesosLista)
            {
                if (data.PID == id)
                {
                    find = true;
                }
                else
                {
                    find = false;
                }
            }
            return find;
        }

        // Eliminar un dato de la lista.
        public void EliminarDatoLista(int id)
        {
            foreach (var data in ProcesosLista)
            {
                if (data.PID == id)
                {
                    ProcesosLista.Remove(data);
                    break;
                }
            }
        }

        // Reiniciar la lista.
        public void ReiniciarLista()
        {
            ProcesosLista.Clear();
        }

        // Muestra el total de procesos.
        public int Total()
        {
            return ProcesosLista.Count();
        }

        // Iniciar lista con datos.
        public void IniciaLista()
        {
            Procesos dt1 = new Procesos("explorer.exe", 16240, "Ejecutando", "Alfredo", 1.5, 33.6, 0, "Explorador de Windows");
            ProcesosLista.Add(dt1);
            Procesos dt2 = new Procesos("System", 4, "Ejecutando", "SYSTEM", 2.5, 8, 0, "NT kernel & System");
            ProcesosLista.Add(dt2);
            Procesos dt3 = new Procesos("Spotify.exe", 17996, "Ejecutando", "Alfredo", 0.2, 253.2, 0, "Spotify");
            ProcesosLista.Add(dt3);
            Procesos dt4 = new Procesos("avp.exe", 3000, "Ejecutando", "SYSTEM", 0.3, 145.5, 0, "Kaspersky Anti-Virus");
            ProcesosLista.Add(dt4);
            Procesos dt5 = new Procesos("audiodg.exe", 27972, "Ejecutando", "SERVICIO LOCAL", 8.5, 58.4, 0, "Aislamiento de gráficos de dispositivo de audio de Windows");
            ProcesosLista.Add(dt5);
            Procesos dt6 = new Procesos("SearchUI.exe", 14356, "Suspendido", "Alfredo", 45.3, 7, 0, "Search and Cortana application");
            ProcesosLista.Add(dt6);
            Procesos dt7 = new Procesos("SkypeApp.exe", 5472, "Suspendido", "Alfredo", 0, 122.9, 0, "SkypeApp");
            ProcesosLista.Add(dt7);
            Procesos dt8 = new Procesos("CCleaner64.exe", 7476, "Ejecutando", "Alfredo", 4.8, 5, 0, "CCleaner");
            ProcesosLista.Add(dt8);
            Procesos dt9 = new Procesos("explorer.exe", 21048, "Ejecutando", "Alfredo", 7, 240.3, 0, "Google Chrome");
            ProcesosLista.Add(dt9);
            Procesos dt10 = new Procesos("AppleMobileDeviceService.exe", 36600, "Ejecutando", "SYSTEM", 0, 1.5, 0, "MobileDeviceService");
            ProcesosLista.Add(dt10);
            Procesos dt11 = new Procesos("sadwd.exe", 8546, "Ejecutando", "SYSTEM", 5.2, 33.6, 0, "SYSTEM");
            ProcesosLista.Add(dt11);
            Procesos dt12 = new Procesos("asdqs.exe", 5545, "Ejecutando", "SYSTEM", 1, 33.6, 0, "SYSTEM");
            ProcesosLista.Add(dt12);
            Procesos dt13 = new Procesos("erdfs.exe", 84538, "Ejecutando", "SYSTEM", 2.2, 2, 0, "SYSTEM");
            ProcesosLista.Add(dt13);
            Procesos dt14 = new Procesos("erds.exe", 8458, "Ejecutando", "SYSTEM", 0.2, 9, 0, "SYSTEM");
            ProcesosLista.Add(dt14);
            Procesos dt15 = new Procesos("fcvews.exe", 844595, "Suspendido", "SERVICIO LOCAL", 0, 8, 0, "SERVICIO LOCAL");
            ProcesosLista.Add(dt15);
            Procesos dt16 = new Procesos("sdeed.exe", 994557, "Ejecutando", "SERVICIO LOCAL", 2.2, 9.6, 0, "SERVICIO LOCAL");
            ProcesosLista.Add(dt16);
            Procesos dt17 = new Procesos("fesd.exe", 3087, "Suspendido", "SERVICIO LOCAL", 0, 45.5, 0, "SERVICIO LOCAL");
            ProcesosLista.Add(dt17);
            Procesos dt18 = new Procesos("Whatsapp.exe", 128668, "Ejecutando", "Alfredo", 8, 154.5, 0, "Whatsapp");
            ProcesosLista.Add(dt18);
            Procesos dt19 = new Procesos("VisualStudio.exe", 1745, "Suspendido", "Alfredo", 0, 250.6, 0, "VisualStudio");
            ProcesosLista.Add(dt19);
            Procesos dt20 = new Procesos("Latex.exe", 23571, "Ejecutando", "Alfredo", 5.5, 111.6, 0, "Texmaker");
            ProcesosLista.Add(dt20);
            Procesos dt21 = new Procesos("Apex.exe", 95137, "Ejecutando", "Alfredo", 2.2, 355.6, 0, "Apex");
            ProcesosLista.Add(dt21);
        }
    }
}
