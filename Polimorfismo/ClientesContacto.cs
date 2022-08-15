using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class ClientesContacto : ClientesBase
    {
        //Instanciar el objeto Direccion, para esto hay que declarar el constructor para hacerlo
        public ClientesContacto()
        {
            _Direccion = new Direcciones();
        }
        public ClientesContacto(int pId, string pNombre, string pClave, string pRFC, int pTipoRegimen,string pNombreContacto, 
                                string pTelefono1, string pTelefono2, string pEmail,
                                string pCalle, string pNumeroExterior, string pNumeroInterior, string pColonia, string pMunicipio, string pEstado, string pCP)
        {
            //Aqui se asignan valores a las propiedades de la clase ClienteBasde
            ////podemos hacerlo porque la estamos heredando
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            //Aqui estamos asignando valores a las propiedades de esta misma clase 
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            //instanciamos el objeto _Direccion de la clase Direcciones, tambien asignamos valores a sus propiedades
            _Direccion = new Direcciones();
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.Estado = pEstado;
            Direccion.CP = pCP;
        }
        //propiedades
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public Direcciones Direccion { get => _Direccion; set => _Direccion = value; }
        //estamos creando una variable compleja, DECLARANDO AL OBJETO _Direccion
        private Direcciones _Direccion;
    }
}
