using System;
using System.Data;
using System.Web.UI.WebControls;

namespace SGSV
{
    public class DalAux : ClsDal
    {

        #region Usuarios

        public static DataSet ValidateUsuario(string UserName, string Password)
        {
            return Exec<DataSet>("dbo.P_S_VALIDATE_USER", true, "@UserName", DalAux.GetValue(UserName), "@Password", DalAux.GetValue(Password));
        }

        public static DataSet GetCoordinadoresCombo()
        {
            return Exec<DataSet>("dbo.P_S_Coordinador_General", true, null);
        }

        public static DataSet GetUserId(int usuario_Id)
        {
            return Exec<DataSet>("dbo.P_S_USUARIO", true, "@IdUsuario", DalAux.GetValue(usuario_Id));
        }

        /// <summary>
        /// Devuelve todos los Usuarios que son responsables regionales o los que 
        /// son responsables locales
        /// </summary>
        /// <param name="bRespRegional">1 = resp. Regional, 0 = resp. Local</param>
        /// <returns></returns>
        public static DataSet GetUserResponsableRegionalLocal(bool bRespRegional)
        {
            int iResp = (bRespRegional == true) ? 1 : 0;

            return Exec<DataSet>("dbo.P_S_Usuario_Responsable", true, "@RespRegional", DalAux.GetValue(iResp));
        }

        #endregion

        #region Estados
        public static DataSet GetEstadosUnidad(int actividad_id, int IntIdOperacion)
        {
            return Exec<DataSet>("dbo.P_S_Estados_Unidad", true, "@Actividad_id", DalAux.GetValue(actividad_id), "@operacion_id", DalAux.GetValue(IntIdOperacion));
        }

        public static String GetEstadoOperacion(int idEstado)
        {
            return (String)Exec<Object>("dbo.P_S_Estado_Operacion_D", true, "@estado_operacion_id", DalAux.GetValue(idEstado));
        }

        public static DataSet GetEstadoProyecto()
        {
            return Exec<DataSet>("dbo.P_S_Estados_Proyecto", true, null);
        }

        public static DataSet GetEstadoDocumentos()
        {
            return Exec<DataSet>("dbo.P_S_Estados_Documentos", true, null);
        }

        public static DataSet GetEstadosPosicion(int estado_id)
        {
            return Exec<DataSet>("dbo.P_S_Estados_Posicion", true, "@estado_posicion_id", DalAux.GetValue(estado_id));
        }

        #endregion

        #region Actividades

        public static string GetDepositoByPosicion(string posicionId)
        {
            return (string)Exec<object>("dbo.P_S_DepositoByPosicion", true, "@posicion_id", posicionId);
        }

        public static string GetCodigoProyectoByProtocolo(string protocolo)
        {
            return (string)Exec<object>("dbo.P_S_CodigoProyectoByProtocolo", true, "@protocolo", protocolo);
        }

        public static int GetTraeTipoOperacion(int intIdOperacion)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_S_TraeTipoOperacion", true, "@intIdOperacion", DalAux.GetValue(intIdOperacion)));
        }
        public static DataSet GetActividadesTipoManual(object idActividad)
        {
            return Exec<DataSet>("dbo.P_S_ActividadesTipoManual", true, "@idactividad", idActividad);
        }

        public static bool InsertUpdateActividad(object idActividad, string descripcion, int usuario_id)
        {
            return Convert.ToBoolean(Convert.ToInt32(Exec<object>("dbo.P_IU_ActividadTipoManual", true,
                    "@actividadId", idActividad,
                    "@descripcionActividad", DalAux.GetValue(descripcion),
                    "@idusuario", DalAux.GetValue(usuario_id))
                    ) > 0);

        }
        public static bool DeleteActividad(int idActividad)
        {
            return Convert.ToBoolean(Convert.ToInt32(Exec<object>("dbo.P_D_ActividadTipoManual", true,
                    "@actividadId", DalAux.GetValue(idActividad))
                    ) > 0);

        }
        #endregion

        #region Kits
        public static void UpdateUnidadOrigen(int unidadId, int unidadOrigen)
        {
            Exec<int>("dbo.P_U_UNIDAD_ORIGEN", true, "@unidad_id", unidadId, "@unidad_origen_id", unidadOrigen);
        }

        public static DataSet GetUnidadOrigen(string nroKit)
        {
            return Exec<DataSet>("dbo.P_S_UNIDAD_ORIGEN", true, "@nro_kit", DalAux.GetValue(nroKit));
        }

        public static DataSet GetKit(int id, int unidad_id)
        {
            return Exec<DataSet>("dbo.P_S_Kit", true, "@kit_id", DalAux.GetValue(id), "@unidad_id", DalAux.GetValue(unidad_id));
        }

        public static DataSet GetKits(int idUnidad)
        {
            return Exec<DataSet>("dbo.P_S_KITs_Unidad", true, "@unidad_id", DalAux.GetValue(idUnidad));
        }

        public static string GetKitsGrouped(int idUnidad)
        {
            DataSet ds = new DataSet();
            ds = Exec<DataSet>("dbo.P_S_KITs_Agrupados", true, "@unidad_id", DalAux.GetValue(idUnidad));
            if (ds != null)
                return ds.Tables[0].Rows[0]["kit"].ToString();
            return "";
        }

        public static DataSet GetKitsExpedicion(int idUnidad)
        {
            return Exec<DataSet>("dbo.P_S_KITs_Unidad_Expedicion", true, "@unidad_id", DalAux.GetValue(idUnidad));
        }

        public static void DeleteKit(int id)
        {
            Exec<int>("dbo.P_D_Kits", true, "@id", DalAux.GetValue(id));
        }
        public static void DeleteDoses(int id)
        {
            Exec<int>("dbo.P_D_Doses", true, "@id", DalAux.GetValue(id));
        }
        public static DataSet InsertKit(int unidad_id, string kit, string posicion_id, int CantidadMaximaKits, int IntIdproducto, int IdUsuario)
        {
            return Exec<DataSet>("dbo.P_I_Kits", true,
                    "@unidad_id", DalAux.GetValue(unidad_id),
                    "@kit", DalAux.GetValue(kit),
                    "@producto_id", DalAux.GetValue(IntIdproducto),
                    "@posicion_id", DalAux.GetValue(posicion_id),
                    "@CantidadMaximaKits", DalAux.GetValue(CantidadMaximaKits),
                    "@usuario_id", DalAux.GetValue(IdUsuario));
        }

        public static DataSet InsertKit_Recep(int unidad_id, string kit, string posicion_id, int CantidadMaximaKits, int IntIdproducto, int IdUsuario)
        {
            return Exec<DataSet>("dbo.P_I_Kits_Recep", true,
                    "@unidad_id", DalAux.GetValue(unidad_id),
                    "@kit", DalAux.GetValue(kit),
                    "@producto_id", DalAux.GetValue(IntIdproducto),
                    "@posicion_id", DalAux.GetValue(posicion_id),
                    "@CantidadMaximaKits", DalAux.GetValue(CantidadMaximaKits),
                    "@usuario_id", DalAux.GetValue(IdUsuario));
        }

        public static DataSet UpdateKit(int kit_id, string kit, string posicion_id, int IntIdproducto, int IntIdUnidad, int IdUsuario)
        {
            return Exec<DataSet>("dbo.P_U_Kits", true,
                    "@kit_id", DalAux.GetValue(kit_id),
                    "@kit", DalAux.GetValue(kit),
                    "@posicion_id", DalAux.GetValue(posicion_id),
                    "@producto_id", DalAux.GetValue(IntIdproducto),
                    "@unidad_id", DalAux.GetValue(IntIdUnidad),
                    "@usuario_id", DalAux.GetValue(IdUsuario));
        }

        public static DataSet InsertKitxRango(int IntIdUnidad, string KitPrefijo, int RangoDesde, int RangoHasta, string posicion_id, int IntIdproducto, int CantidadMaximaKits, int usuario_id)
        {
            return Exec<DataSet>("dbo.P_I_KITSXRANGO", true,
                    "@unidad_id", DalAux.GetValue(IntIdUnidad),
                    "@producto_id", DalAux.GetValue(IntIdproducto),
                    "@KitPrefijo", DalAux.GetValue(KitPrefijo),
                    "@RangoDesde", DalAux.GetValue(RangoDesde.ToString()),
                    "@RangoHasta", DalAux.GetValue(RangoHasta),
                    "@posicion_id", DalAux.GetValue(posicion_id),
                    "@CantidadMaximaKits", DalAux.GetValue(CantidadMaximaKits),
                    "@usuario_id", DalAux.GetValue(usuario_id));
        }

        public static DataSet InsertKitxRangoRecep(int IntIdUnidad, string KitPrefijo, string RangoDesde, string RangoHasta, string posicion_id, int IntIdproducto, int CantidadMaximaKits, int usuario_id)
        {
            return Exec<DataSet>("dbo.P_I_KITSXRANGO_Recep", true,
                    "@unidad_id", DalAux.GetValue(IntIdUnidad),
                    "@producto_id", DalAux.GetValue(IntIdproducto),
                    "@KitPrefijo", DalAux.GetValue(KitPrefijo),
                    "@RangoDesde", DalAux.GetValue(RangoDesde),
                    "@RangoHasta", DalAux.GetValue(RangoHasta),
                    "@posicion_id", DalAux.GetValue(posicion_id),
                    "@CantidadMaximaKits", DalAux.GetValue(CantidadMaximaKits),
                    "@usuario_id", DalAux.GetValue(usuario_id));
        }

        public static DataSet GetTipoKits()
        {
            return Exec<DataSet>("dbo.P_S_TIPO_KIT", true, null);
        }
        #endregion

        #region Reportes
        public static DataSet GetReporte()
        {
            return Exec<DataSet>("dbo.P_S_Reporte", true, null);
        }
        public static DataSet GetRotuloUnidad(int idUnidad)
        {
            return Exec<DataSet>("dbo.P_S_RotuloUnidad", true, "@unidad_id", idUnidad);
        }
        #endregion

        #region SubProyectos
        public static DataSet ExisteSubPryecto(string subProyecto)
        {
            return Exec<DataSet>("dbo.P_S_SUB_PROYECTO_EXISTE", true, "@subProyecto", DalAux.GetValue(subProyecto));
        }

        public static DataSet GetSubProyectoEstado()
        {
            return Exec<DataSet>("dbo.P_S_SUBPROYECTOS_ESTADOS", true, null);
        }

        public static DataSet GetSubProyectoSeleccion(string codigo_subproyecto, string proyecto, string codigo_proyecto,
            string sponsor, int estado, int tipo, int IdUsuario)
        {
            return Exec<DataSet>("dbo.P_S_SUBPROYECTOS_SELECCION", true,
                "@codigo_subproyecto", DalAux.GetValue(codigo_subproyecto),
                "@proyecto", DalAux.GetValue(proyecto),
                "@codigo_proyecto", DalAux.GetValue(codigo_proyecto),
                "@sponsor", DalAux.GetValue(sponsor),
                "@estado", DalAux.GetValue(estado),
                "@tipo", DalAux.GetValue(tipo),
                "@IdUsuario", DalAux.GetValue(IdUsuario));
        }

        public static DataSet GetListaProductos(string idSubProy, string codigo_producto, string lote, DateTime? fechaVto, string nro_kit)
        {
            return Exec<DataSet>("dbo.P_S_ListaPRODUCTOS", true, "@subproyecto_id", idSubProy, "@codigo_producto", codigo_producto, "@lote", lote, "@fecha_vencimiento", fechaVto, "@nro_kit", @nro_kit);
        }

        public static DataSet GetProductosTrail(int idSubProy, int producto_id, int idUsuario)
        {
            return Exec<DataSet>("dbo.P_S_SubPActividad", true, "@subproyecto_id", idSubProy,
                "@producto_id", GetValue(producto_id), "@IdUsuario", idUsuario);
        }

        #endregion

        #region ClientesDirectos
        public static DataSet GetClientes_directos_Combo()
        {
            return Exec<DataSet>("dbo.P_S_clientes_directos_Combo", true, null);
        }
        #endregion

        #region Warehouses

        public static DataSet GetWarehouses(bool? Propio)
        {
            return Exec<DataSet>("dbo.P_S_Warehouses", true, "@Propio", Propio);
        }
        public static DataSet GetWarehouse(int warehouse_id)
        {
            return Exec<DataSet>("dbo.P_S_Warehouses", true, "@warehouse_id", warehouse_id);
        }
        public static DataSet GetDepositos(int warehouse_id)
        {
            return Exec<DataSet>("dbo.P_S_Depositos", true, "@warehouse_id", warehouse_id);
        }
        public static DataSet GetDeposito(string deposito_id)
        {
            return Exec<DataSet>("dbo.P_S_Deposito", true, "@deposito_id", deposito_id);
        }
        public static bool WarehouseCodeExiste(string whCode)
        {
            return Convert.ToBoolean(Exec<object>("dbo.P_S_WHCodeExiste", true, "@whCode", whCode));
        }
        public static int WarehouseNextCode(string paisCode)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_S_WHNextCode", true, "@paisCode", paisCode));
        }
        public static int DepotNextCode(int warehouse_id, string CACode)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_S_DepotNextCode", true, "@warehouse_id", warehouse_id, "@CACode", CACode));
        }

        public static int SaveWarehouse(int warehouse_id, string Code, string Nombre, string telefono, string fax,
            string email, string direccion, int Pais_Id, string City, string ZipCode, string Notas, bool propio)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_IU_Warehouses", true, "@warehouse_id", warehouse_id, "@Code", Code,
                "@Nombre", Nombre, "@telefono", telefono, "@fax", fax, "@email", email, "@direccion", direccion,
                "@Pais_Id", Pais_Id, "@City", City, "@ZipCode", ZipCode, "@Notas", Notas, "@propio", propio));
        }

        public static void SaveDeposito(string deposito_id, int warehouse_id, string nombre, int cant_x_m3,
            int tipo_subproyecto_id, int condicion_almac_id, bool sustancia_controlada, int id_usuario, bool tipoDevolucion, string deposito_id_antiguo)
        {
            Exec<int>("dbo.P_IU_Depositos", true, "@deposito_id", deposito_id, "@warehouse_id", warehouse_id, "@nombre", nombre,
                "@cant_x_m3", cant_x_m3, "@tipo_subproyecto_id", tipo_subproyecto_id, "@condicion_almac_id", condicion_almac_id,
                "@sustancia_controlada", sustancia_controlada, "@id_usuario", id_usuario, "@tipoDevolucion", tipoDevolucion, "@deposito_id_antiguo", deposito_id_antiguo);
        }

        public static bool DepositoExiste(string idDeposito)
        {
            return Convert.ToBoolean(Exec<object>("dbo.P_S_DepositoExiste", true, "@deposito_id", idDeposito));
        }

        public static DataRow GetCondicionAlmacenamiento(int condicion_id)
        {
            return Exec<DataSet>("dbo.P_S_Condicion_Almacenamiento", true, "@condicion_id", condicion_id).Tables[0].Rows[0];
        }

        public static DataSet GetPosicionesDeposito(string idDeposito)
        {
            return Exec<DataSet>("dbo.P_S_Posiciones", true, "@deposito_id", idDeposito);
        }
        public static DataSet GetPosicionDeDeposito(string idPosicion)
        {
            return Exec<DataSet>("dbo.P_S_Posiciones", true, "@posicion_id", idPosicion);
        }
        public static DataSet GetPosicionesSeleccion(string idDeposito, string rack, string estante, string columna, int idEstadoPosicion, bool habilitado)
        {
            return Exec<DataSet>("dbo.P_S_Posiciones_Seleccion", true, "@deposito_id", idDeposito, "@rack", rack, "@estante", estante, "@columna", columna, "@estado_posicion_id", idEstadoPosicion, "@habilitado", habilitado);
        }
        public static DataSet InsertPosicionDeDeposito(string idDeposito, string rack, string estante, string columna, int idEstadoPosicion, bool habilitado, int usuario_id)
        {
            return Exec<DataSet>("dbo.P_I_Posiciones", true,
                "@deposito_id", idDeposito,
                "@rack", rack,
                "@estante", estante,
                "@columna", columna,
                "@estado_posicion_id", idEstadoPosicion,
                "@habilitado", habilitado,
                "@usuario_id", DalAux.GetValue(usuario_id));
        }

        public static DataSet UpdatePosicion(string idPosicion, bool habilitado)
        {
            return Exec<DataSet>("dbo.P_U_Posiciones", true, "@posicion_id", idPosicion, "@habilitado", habilitado);
        }

        public static DataSet DeletePosicion(string idPosicion)
        {
            return Exec<DataSet>("dbo.P_D_Posiciones", true, "@posicion_id", idPosicion);
        }
        #endregion

        #region Comunes
        public static void FillCbo(ref System.Web.UI.WebControls.DropDownList cbo, string NombreProcedure, bool insertEmptyOption, string DataValueField, string DataTextField, params object[] parametros)
        {
            cbo.DataTextField = DataTextField;
            cbo.DataValueField = DataValueField;
            cbo.DataSource = Exec<DataSet>(NombreProcedure, true, parametros);
            cbo.DataBind();
            if (insertEmptyOption)
            {
                cbo.Items.Insert(0, new System.Web.UI.WebControls.ListItem(string.Empty, "0"));
            }
        }

        /// <summary>
        /// ADVERTENCIA!!! ESTE METODO AGREGA string.Empty AL VALOR VACÍO.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="NombreProcedure"></param>
        /// <param name="insertEmptyOption"></param>
        /// <param name="DataValueField"></param>
        /// <param name="DataTextField"></param>
        /// <param name="parametros"></param>
        /// <remarks>ADVERTENCIA!!! ESTE METODO AGREGA string.Empty AL VALOR VACÍO.</remarks>
        public static void FillDropDownList(ref DropDownList cbo, string NombreProcedure, bool insertEmptyOption, string DataValueField, string DataTextField, params object[] parametros)
        {
            cbo.DataTextField = DataTextField;
            cbo.DataValueField = DataValueField;
            cbo.DataSource = Exec<DataSet>(NombreProcedure, true, parametros);
            cbo.DataBind();
            if (insertEmptyOption)
            {
                cbo.Items.Insert(0, new ListItem(string.Empty, string.Empty));
            }
        }

        internal static object GetValue(int valor)
        {
            if (valor == 0)
                return System.DBNull.Value;
            return valor;
        }
        internal static object GetValue(string valor)
        {
            if (valor == string.Empty)
                return System.DBNull.Value;
            return valor;
        }

        public static bool DbToBoolean(object cl)
        {
            if (cl is System.DBNull)
                return false;
            else
                return (bool)cl;
        }

        public static T GetDBVal<T>(object data)
        {
            if (data is System.DBNull)
                return default(T);
            else
                return (T)data;
        }

        public static string DateSQL(string fecha)
        {
            string rta = "";
            if (fecha.Trim() != "")
            {
                try
                {
                    string[] ArrayFecha = fecha.Split('/');
                    string Mes = ArrayFecha[1].ToUpper();
                    string Meses = "ENE,FEB,MAR,ABR,MAY,JUN,JUL,AGO,SEP,OCT,NOV,DIC,";
                    if (Meses.IndexOf(Mes + ",") != -1)
                        rta = DateTime.ParseExact(fecha, Config.ConfigManager.DateFmt, new System.Globalization.CultureInfo("ES-es")).ToString("yyyyMMdd");
                    else
                        rta = DateTime.ParseExact(fecha, Config.ConfigManager.DateFmt, new System.Globalization.CultureInfo("EN-us")).ToString("yyyyMMdd");
                }
                catch
                {
                    throw new ApplicationException("Bad Date Format: " + fecha);
                }
            }
            return rta;
        }

        public static DataSet ExecString(string sqlStr)
        {
            return Exec<DataSet>(sqlStr, false);
        }
        #endregion

        #region Sponsors

        public static DataSet GetSponsors()
        {
            return Exec<DataSet>("dbo.P_S_Sponsors", true, null);
        }

        #endregion

        #region Monitores

        public static DataSet GetMonitoresDeTemperatura()
        {
            return Exec<DataSet>("dbo.P_S_Monitores", true);
        }
        public static DataSet GetMonitorDeTemperatura(int idMonitor)
        {
            return Exec<DataSet>("dbo.P_S_MONITOR", true, "@monitor_id", idMonitor);
        }

        public static Int32 InsertUpdateMonitorTemperatura(object idMonitor, string descripcion, string descripcion_corta, int idUsuario)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_IU_Monitor", true,
                    "@monitorId", idMonitor,
                    "@descripcionMonitor", DalAux.GetValue(descripcion),
                    "@descripcionMonitorCorta", DalAux.GetValue(descripcion_corta),
                    "@idusuario", DalAux.GetValue(idUsuario))
                    );

        }

        public static bool DeleteMonitorTemperatura(int idMonitor)
        {
            return Convert.ToBoolean(Convert.ToInt32(Exec<object>("dbo.P_D_MONITOR", true,
                    "@monitorId", DalAux.GetValue(idMonitor))
                    ) > 0);

        }

        #endregion

        #region Packaging

        public static DataSet GetPackaging()
        {
            return Exec<DataSet>("dbo.P_S_Packaging", true);
        }
        public static DataSet GetPackaging(int idPackaging)
        {
            return Exec<DataSet>("dbo.P_S_Packaging_id", true, "@packaging_id", idPackaging);
        }

        public static Int32 InsertUpdatePackaging(object idPackaging, string descripcion, string descripcion_corta, int idUsuario)
        {
            return Convert.ToInt32(Exec<object>("dbo.P_IU_Packaging", true,
                    "@packaging_id", idPackaging,
                    "@descripcionPackaging", DalAux.GetValue(descripcion),
                    "@descripcionPackaging_corta", DalAux.GetValue(descripcion_corta),
                    "@idusuario", DalAux.GetValue(idUsuario))
                    );

        }

        public static bool DeletePackaging(int idPackaging)
        {
            return Convert.ToBoolean(Convert.ToInt32(Exec<object>("dbo.P_D_PACKAGING", true,
                    "@packaging_id", DalAux.GetValue(idPackaging))
                    ) > 0);

        }

        public static DataSet GetProducto(int productId)
        {
            return Exec<DataSet>("dbo.P_S_Producto", true, "@producto_id", productId);
        }

        #endregion

    }
}

