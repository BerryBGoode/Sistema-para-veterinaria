using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorEmpleado
    {
        #region Lectura de datos 
        public static DataTable CargarMunicipio_Controlador(int id)
        {
            return ModeloEmpleados.CargarMunicipio(id);
        }
        public static DataTable CargarMunicipioInicio()
        {
            return ModeloEmpleados.CargarMunicipioInicio();
        }
        public static DataTable CargarTipoDocumentos_Controlador()
        {
            return ModeloEmpleados.CargarTipoDocumentos();
        }
        public static DataTable CargarDepartamento_Controlador()
        {
            return ModeloEmpleados.CargarDepartamento();
        }
        public static DataTable CargarCargo()
        {
            return ModeloEmpleados.CargarCargo();
        }
        //dgv Empleado
        public static DataTable CargarEmpleados_Controlador()
        {
            return ModeloEmpleados.CargarListasEmpleados();
        }
        public static DataTable CargarEmpleados_ControladorGeneral()
        {
            return ModeloEmpleados.CargarListasEmpleadosGeneral();
        }
        public static DataTable CargarEmpleadosBuscar(string buscar)
        {
            return ModeloEmpleados.CargarListasEmpleadosGeneralBuscar(buscar);
        }
        //Dgv Teléfono
        public static DataTable CargarNumTelefono_Controlador()
        {
            return ModeloEmpleados.CargarNumTelefono();
        }

        #endregion
        
        //Atributos
        public static int idempleado { get; set; }
        public string nombre_emp { get; set; }
        public string apellido_emp { get; set; }
        public string fecha_nacimiento { get; set; }
        public int idtipodocumento { get; set; }
        public string num_doc { get; set; }
        public int idmunicipio { get; set; }
        public int idcargo { get; set; }
        //Constructor
        public ControladorEmpleado()
        {

        }
        public ControladorEmpleado(string pnombre_emp, string papellido_emp, string pfecha_nacimiento, int pidtipodocumento, string pnum_doc, int pidmunicipio, int pidcargo)
        {
            nombre_emp = pnombre_emp;
            apellido_emp = papellido_emp;
            fecha_nacimiento = pfecha_nacimiento;
            idtipodocumento = pidtipodocumento;
            num_doc = pnum_doc;
            idmunicipio = pidmunicipio;
            idcargo = pidcargo;
        }
        #region Métodos
        //Inserción
        public bool EnviarDatos()
        {
            return ModeloEmpleados.RegistrarEmpleado(nombre_emp, apellido_emp, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idcargo);
        }
        //Actualización
        public static DataTable CargarTipodocinnerjoin(string id)
        {
            return ModeloEmpleados.CargarTipoDocumentoInner(id);
        }
        public static DataTable CargarMunicipioInnerJoin(string id)
        {
            return ModeloEmpleados.CargarMunicipioInner(id);
        }
        public static DataTable CargarDepartamentoInnerJoin(string departamento)
        {
            return ModeloEmpleados.CargarDepartamentosInner(departamento);
        }
        public static DataTable CargarCargoInnerJoin(string cargo)
        {
            return ModeloEmpleados.cargarCargoInner(cargo);
        }
        public bool ActualizarDatos_Controlador()
        {
            return ModeloEmpleados.ActualizarEmpleado(idempleado, nombre_emp, apellido_emp, fecha_nacimiento, idtipodocumento, num_doc, idmunicipio, idcargo);
        }
        //Eliminación
        public static int EliminarEmpleado_Controlador()
        {
            return ModeloEmpleados.EliminarEmpleado(idempleado);
        }
        #endregion

        public class ControladorContacto
        {
            public static int idcontacto_emp { get; set; }
            public string contacto { get; set; }
            public ControladorContacto()
            {

            }
            public ControladorContacto(string pcontacto, int pidempleado)
            {
                contacto = pcontacto;
                idempleado = pidempleado;

            }
            
            #region Inserción de número de teléfono
            public int BuscarEmpleado(string pdocumento)
            {
                return ModeloEmpleados.BuscarEmpleado(pdocumento);
            }
            public bool EnviarTelefono()
            {
                return ModeloEmpleados.RegistrarTelefono(contacto, idempleado);
            }
            #endregion

            #region Actualizar Número de teléfono
            public bool ActualizarContacto_Controlador()
            {
                return ModeloEmpleados.ActualizarTelefono(idcontacto_emp, contacto, idempleado);
            }
            #endregion
         
        }
    }

}
