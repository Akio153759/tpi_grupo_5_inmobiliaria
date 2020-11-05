using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIME
{
    class inicial
    {
        int idModulador;
        string nombreModulador;
        int precioCostoKg;
        

        double pesoEstimado;
        string nombreReferencia;
        DateTime fechaModificacion;
        int stock;

        public int pIDinicial
        {
            get { return idModulador; }
            set { idModulador = value; }
        }

        public string pNombreInicial
        {
            get { return nombreModulador; }
            set { nombreModulador = value; }
        }
        
        public int pPrecioXkg
        {
            get { return precioCostoKg; }
            set { precioCostoKg = value; }
        }
        

        public double pPesoEstimado
        {
            get { return pesoEstimado; }
            set { pesoEstimado = value; }
        }
        

        public int pStock
        {
            get { return stock; }
            set { stock = value; }
        }
        
        public DateTime pFechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public string pNombreReferencia { get => nombreReferencia; set => nombreReferencia = value; }

        override public string ToString()
        {
            return "Modulador " + nombreModulador  ;
        }
      
    }
}
