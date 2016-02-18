using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCongreso.Modelos
{
    public class ModeloParticipante
    {
        public int ID {get;set;}
        public string lname { get; set; }
        public string fname { get; set; }
        public string address { get;set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string reg_type { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string company { get; set; }
        public string co_address { get; set; }
        public string co_city { get; set; }
        public string co_state { get; set; }
        public string co_zip { get; set; }
        public string date { get; set; }
        public string event_id { get; set; }
        public string coupon { get; set; }
        public string quantity { get; set; }
        public string attendees { get; set; }
        public string tickets { get; set; }
        public string payment { get; set; }
        public string tax { get; set; }
        public string payment_status { get; set; }
        public string amount_pd { get; set; }
        public string payment_date { get; set; }
        public string token { get; set; }
        public string waiver_agree { get; set; }


        


        public ModeloParticipante() { }//este es un constructor vacio que sirve en caso de querer crear objetos sin valores

        public ModeloParticipante(int idParticipante, string apellido, string nombre,string address, string citys,string state,string zip,string reg_type,string correoElectronico,string telefono,string participanteCompany,string participanteCoaddress,string participanteCoCity,string participanteCostate,string participanteCoZip, string participanteDate, string participanteEvent, string participanteCoupon,string participanteQuantity,string participanteAttendees,string participanteTickets,string participantePayment,string participanteTax,string participantePaymentStatus,string participanteAmount,string participantePaymentDate,string participanteToken,string participanteWaiver)
        {
            this.ID = idParticipante;
            this.lname = apellido;
            this.fname = nombre;
            this.address = address;
            this.city = citys;
            this.state = state;
            this.zip = zip;
            this.reg_type = reg_type;
            this.email = correoElectronico;
            this.phone = telefono;
            this.company = participanteCompany;
            this.co_address = participanteCoaddress;
            this.co_city = participanteCoCity;
            this.co_state = participanteCostate;
            this.co_zip = participanteCoZip;
            this.date = participanteDate;
            this.event_id = participanteEvent;
            this.coupon = participanteCoupon;
            this.quantity = participanteQuantity;
            this.attendees = participanteAttendees;
            this.tickets = participanteTickets;
            this.payment = participantePayment;
            this.tax = participanteTax;
            this.payment_status = participantePaymentStatus;
            this.amount_pd = participanteAmount;
            this.payment_date = participantePaymentDate;
            this.token = participanteToken;
            this.waiver_agree = participanteWaiver;

        }
    }
}
