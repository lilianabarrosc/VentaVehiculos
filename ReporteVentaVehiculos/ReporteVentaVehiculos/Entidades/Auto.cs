using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReporteVentaVehiculos.Entidades
{
    public class Auto
    {
        public Auto()
        {}

        //atributos de la entidad Auto (ctrl+re para controladores)
        private int _idauto;
        private string _marca;
        private string _modelo;
        private string _tipoCombustible;
        private int _año;

        public int Idauto
        {
            get { return _idauto; }
            set { _idauto = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string TipoCombustible
        {
            get { return _tipoCombustible; }
            set { _tipoCombustible = value; }
        }

        public int Año
        {
            get { return _año; }
            set { _año = value; }
        }
    }
}