using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Inmobiliaria
{
    class clsModelo
    {
        Datos oDatos = new Datos();
        
        int aaaa; //Caja 1
        string bbbb; //Caja 2
        string cccc; //Caja 3
        string dddd; //Caja 4
        int eeee; //Caja 5
        double gggg; //Caja 6
        int ffff; //Caja 7
        int kkkk; //Caja 8
        int hhhh; //Caja 9

        int llll;
        int mmmm; // Combo A
        int nnnn; // Combo B
        int oooo; // Combo C
        int pppp; // Combo D
        int qqqq; // Combo E
       


        DateTime jjjj; //CajaFecha 1
        DateTime rrrr; //CajaFecha 2

        string nombreTabla;
        string campoPK1;
        string campoDisplay1;

        public int Aaaa { get => aaaa; set => aaaa = value; }
        public string Bbbb { get => bbbb; set => bbbb = value; }
        public string Cccc { get => cccc; set => cccc = value; }
        public string Dddd { get => dddd; set => dddd = value; }
        public int Eeee { get => eeee; set => eeee = value; }
        public double Gggg { get => gggg; set => gggg = value; }
        public int Ffff { get => ffff; set => ffff = value; }
        public int Kkkk { get => kkkk; set => kkkk = value; }
        public int Hhhh { get => hhhh; set => hhhh = value; }
        public int Llll { get => llll; set => llll = value; }
        public int Mmmm { get => mmmm; set => mmmm = value; }
        public int Nnnn { get => nnnn; set => nnnn = value; }
        public int Oooo { get => oooo; set => oooo = value; }
        public int Pppp { get => pppp; set => pppp = value; }
        public int Qqqq { get => qqqq; set => qqqq = value; }
        public DateTime Jjjj { get => jjjj; set => jjjj = value; }
        public DateTime Rrrr { get => rrrr; set => rrrr = value; }
        public string NombreTabla { get => nombreTabla; set => nombreTabla = value; }
        public string CampoPK1 { get => campoPK1; set => campoPK1 = value; }
        public string CampoDisplay1 { get => campoDisplay1; set => campoDisplay1 = value; }


        //////////////////////////////////////////////////////////////////////////////////

        override public string ToString()
        {
            return "Tabla " + NombreTabla;
        }

        public DataTable recuperar()
        {
            return oDatos.consultarTabla(NombreTabla);
        }

        public void actualizar()
        {
            string consultaSQL = "UPDATE " + NombreTabla + " SET bbbb=@bbbb" +
                                                                ",cccc=@cccc," +
                                                                ", dddd=@dddd " +
                                                                ", eeee=@eeee " +
                                                                ", ffff=@ffff" +
                                                                ", gggg=@gggg " +
                                                                ", hhhh=@hhhh " +
                                                                ", kkkk=@kkkk " +
                                                                ", llll=@llll " +
                                                                ", mmmm=@mmmm " +
                                                                ", nnnn=@nnnn " +
                                                                ", oooo=@oooo " +
                                                                ", pppp=@pppp " +
                                                                ", qqqq=@qqqq " +
                                                                " WHERE IdModulador = @aaaa";
            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;

            oDatos.pComando.Parameters.Clear();
            oDatos.pComando.Parameters.AddWithValue("@aaaa", this.Aaaa);
            oDatos.pComando.Parameters.AddWithValue("@bbbb", this.Bbbb);
            oDatos.pComando.Parameters.AddWithValue("@cccc", this.Cccc);
            oDatos.pComando.Parameters.AddWithValue("@dddd", this.Dddd);
            oDatos.pComando.Parameters.AddWithValue("@eeee", this.Eeee);
            oDatos.pComando.Parameters.AddWithValue("@ffff", this.Ffff);
            oDatos.pComando.Parameters.AddWithValue("@gggg", this.Gggg);
            oDatos.pComando.Parameters.AddWithValue("@hhhh", this.Hhhh);
            oDatos.pComando.Parameters.AddWithValue("@jjjj", this.Jjjj);
            oDatos.pComando.Parameters.AddWithValue("@kkkk", this.Kkkk);
            oDatos.pComando.Parameters.AddWithValue("@llll", this.Llll);
            oDatos.pComando.Parameters.AddWithValue("@mmmm", this.Mmmm);
            oDatos.pComando.Parameters.AddWithValue("@nnnn", this.Nnnn);
            oDatos.pComando.Parameters.AddWithValue("@oooo", this.Oooo);
            oDatos.pComando.Parameters.AddWithValue("@pppp", this.Pppp);
            oDatos.pComando.Parameters.AddWithValue("@qqqq", this.Qqqq);



            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();



        }
       
        public void insertar()
        {
            string consultaSQL = "INSERT INTO " + NombreTabla + " ( " +
                                                                    ", bbbb" +
                                                                    ", cccc" +
                                                                    ", dddd " +
                                                                    ", eeee " +
                                                                    ", ffff " +
                                                                    ", gggg  " +
                                                                    ", hhhh  " +
                                                                    ", jjjj " +
                                                                    ", kkkk " +
                                                                    ", llll " +
                                                                    ", mmmm " +
                                                                    ", nnnn " +
                                                                    ", oooo " +
                                                                    ", pppp " +
                                                                    ", qqqq " +
                                                                     ")" +
                                                          " VALUES ( " +
                                                                    ",@bbbb " +
                                                                    ", @cccc " +
                                                                    ", @dddd " +
                                                                    ", @eeee " +
                                                                    ", @ffff " +
                                                                    ", @gggg " +
                                                                    ", @hhhh " +
                                                                    ", @jjjj " +
                                                                    ", @kkkk " +
                                                                    ", @llll " +
                                                                    ", @mmmm " +
                                                                    ", @nnnn " +
                                                                    ", @oooo " +
                                                                    ", @pppp " +
                                                                    ", @qqqq " +
                                                                    ")";

            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;

            oDatos.pComando.Parameters.Clear();
            oDatos.pComando.Parameters.AddWithValue("@aaaa", this.Aaaa);
            oDatos.pComando.Parameters.AddWithValue("@bbbb", this.Bbbb);
            oDatos.pComando.Parameters.AddWithValue("@cccc", this.Cccc);
            oDatos.pComando.Parameters.AddWithValue("@dddd", this.Dddd);
            oDatos.pComando.Parameters.AddWithValue("@eeee", this.Eeee);
            oDatos.pComando.Parameters.AddWithValue("@ffff", this.Ffff);
            oDatos.pComando.Parameters.AddWithValue("@gggg", this.Gggg);
            oDatos.pComando.Parameters.AddWithValue("@hhhh", this.Hhhh);
            oDatos.pComando.Parameters.AddWithValue("@jjjj", this.Jjjj);
            oDatos.pComando.Parameters.AddWithValue("@kkkk", this.Kkkk);
            oDatos.pComando.Parameters.AddWithValue("@llll", this.Llll);
            oDatos.pComando.Parameters.AddWithValue("@mmmm", this.Mmmm);
            oDatos.pComando.Parameters.AddWithValue("@nnnn", this.Nnnn);
            oDatos.pComando.Parameters.AddWithValue("@oooo", this.Oooo);
            oDatos.pComando.Parameters.AddWithValue("@pppp", this.Pppp);
            oDatos.pComando.Parameters.AddWithValue("@qqqq", this.Qqqq);


            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();



        }
        public void eliminar(int PK)
        {
            string consultaSQL = "DELETE FROM " + NombreTabla + " WHERE aaaa = " + PK;
            oDatos.conectarBD();
            oDatos.pComando.CommandText = consultaSQL;
            oDatos.pComando.ExecuteNonQuery();
            oDatos.desconectarBD();


        }

    }
}
