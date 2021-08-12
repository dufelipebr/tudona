using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TudoNaStoreEntity
{
    public enum ClientType { F, J};
    public class ClientEntity
    {
        private int clientID;
        private string clientHost;
        private string clientContactName;
        private string clientPhoneNumber;
        private int clientRegionID;
        private int clientStatusID;
        private string clientContactNumber;
        private string geolocation;
        private string zipcode;
        private string fullAddress;
        private string addressNum;
        private string addressCom;
        private string addressNgh;
        private string addressSta;
        private ClientType typeCli;  // F or J
        private string customerFullName;
        private string socialNumber;
        private string facebookID;
        private string instagramID;
        private string email;
        private string whatsApp;



        public ClientEntity()
        {
            this.clientID = 0;
            this.clientHost = "";
            this.clientContactName = "";
            this.clientPhoneNumber = "";
            this.clientRegionID = 0;
            this.clientStatusID = 0;
            this.clientContactNumber = "";
            this.geolocation = "";
            this.zipcode = "";
            this.fullAddress = "";
            this.addressNum = "";
            this.addressCom = "";
            this.addressNgh = "";
            this.AddressSta = "";
        }

        public ClientEntity(string addressCom)
        {
            this.AddressCom = addressCom;
        }

        public int ClientID
        {
            get
            {
                return clientID;
            }

            set
            {
                clientID = value;
            }
        }

        public string ClientHost
        {
            get
            {
                return clientHost;
            }

            set
            {
                clientHost = value;
            }
        }

        public string ClientContactName
        {
            get
            {
                return clientContactName;
            }

            set
            {
                clientContactName = value;
            }
        }

        public string ClientPhoneNumber
        {
            get
            {
                return clientPhoneNumber;
            }

            set
            {
                clientPhoneNumber = value;
            }
        }

        public int ClientRegionID
        {
            get
            {
                return clientRegionID;
            }

            set
            {
                clientRegionID = value;
            }
        }

        public int ClientStatusID
        {
            get
            {
                return clientStatusID;
            }

            set
            {
                clientStatusID = value;
            }
        }

        public string ClientContactNumber
        {
            get
            {
                return clientContactNumber;
            }

            set
            {
                clientContactNumber = value;
            }
        }

        public string Geolocation
        {
            get
            {
                return geolocation;
            }

            set
            {
                geolocation = value;
            }
        }

        public string Zipcode
        {
            get
            {
                return zipcode;
            }

            set
            {
                zipcode = value;
            }
        }

        public string FullAdress
        {
            get
            {
                return fullAddress;
            }

            set
            {
                fullAddress = value;
            }
        }

        public string AddressNum
        {
            get
            {
                return addressNum;
            }

            set
            {
                addressNum = value;
            }
        }

        public string AddressNgh
        {
            get
            {
                return addressNgh;
            }

            set
            {
                addressNgh = value;
            }
        }

        public string AddressCom
        {
            get
            {
                return addressCom;
            }

            set
            {
                addressCom = value;
            }
        }

        public string AddressSta
        {
            get
            {
                return addressSta;
            }

            set
            {
                addressSta = value;
            }
        }

        public ClientType TypeCli
        {
            get
            {
                return typeCli;
            }

            set
            {
                typeCli = value;
            }
        }

        public string CustomerFullName
        {
            get
            {
                return customerFullName;
            }

            set
            {
                customerFullName = value;
            }
        }

        public string SocialNumber
        {
            get
            {
                return socialNumber;
            }

            set
            {
                socialNumber = value;
            }
        }

        public string InstagramID
        {
            get
            {
                return instagramID;
            }

            set
            {
                instagramID = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FacebookID
        {
            get
            {
                return facebookID;
            }

            set
            {
                facebookID = value;
            }
        }

        public string WhatsApp
        {
            get
            {
                return whatsApp;
            }

            set
            {
                whatsApp = value;
            }
        }

        public bool Validate()
        {
            Regex addressNumberRegExp = new Regex(@"^[1-9]\d{1,7}$");
            Regex cepRegExp = new Regex(@"^\d{5}-\d{3}$");
            Regex telefoneRegExp = new Regex(@"^\([1-9]{2}\)(?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
            Regex emailRegExp = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");

            bool isValid = true;

            if (CustomerFullName.Trim() == "")
            {
                throw new EntityException("Invalid Customer FullName. (empty)");
            }

            if (SocialNumber.Trim() == "")
            {
                throw new EntityException("Invalid Customer Social Number. (empty)");
            }

            if (ClientHost.Length <= 0 || ClientHost.Length > 200)
            {
                throw new EntityException("Invalid character lenght for Client Host");
                //errors.Insert(0, );
                //isValid = false;
            }
            if (ClientContactName.Length <= 0 || ClientHost.Length > 50)
            {
                throw new EntityException("Invalid character lenght for Contact Name");
                //errors.Insert(0, "Invalid character lenght for Contact Name");
                //isValid = false;
            }
            if (ClientPhoneNumber.Length <= 0 || ClientPhoneNumber.Length > 15)
            {
                throw new EntityException("Invalid character lenght for Phone Number");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }

            if (ClientRegionID <= 0)
            {
                throw new EntityException("Invalid Region ID");
                //errors.Insert(0, "Invalid Region ID");
                //isValid = false;
            }
            if (ClientStatusID <= 0)
            {
                throw new EntityException("Invalid Status ID");
                //errors.Insert(0, "Invalid Status ID");
                //isValid = false;
            }
            if (ClientPhoneNumber.Length < 0 || ClientPhoneNumber.Length > 15)
            {
                throw new EntityException("Invalid character lenght for Client Phone Number");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (this.ClientPhoneNumber != null && !telefoneRegExp.IsMatch(this.ClientPhoneNumber))
            {
                throw new EntityException("Invalid Mask for Phone Number. Supported Format: (00)0000-0000");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (ClientContactNumber.Length < 0 || ClientContactNumber.Length > 15)
            {
                throw new EntityException("Invalid character lenght for Client Contact Number");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (this.ClientContactNumber != null && !telefoneRegExp.IsMatch(this.ClientContactNumber))
            {
                throw new EntityException("Invalid Mask for Contact Number. Supported Format: (00)0000-0000");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (FullAdress.Length <= 0 || Geolocation.Length > 200)
            {
                throw new EntityException("Invalid character lenght for Full Address");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (Geolocation.Length <= 0 || Geolocation.Length > 200)
            {
                throw new EntityException("Invalid character lenght for Geolocation ");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (Zipcode.Length <= 0 || Zipcode.Length > 10)
            {
                throw new EntityException("Invalid character lenght for Zipcode");
                //errors.Insert(0, "Invalid character lenght for Phone Number");
                //isValid = false;
            }
            if (this.Zipcode != null && !cepRegExp.IsMatch(this.Zipcode))
            {
                throw new EntityException("Invalid Zipcode. Format 00000-000.");
            }
            if (this.AddressNum == "" )
            {
                throw new EntityException("Invalid Address Number. Obrigatory.");
            }
            if ((this.AddressNum != null && !addressNumberRegExp.IsMatch(this.AddressNum)))
            {
                throw new EntityException("Invalid Address Number Format. Expected 7 digits number.");
            }
            if (this.AddressNgh.Trim() == "" || this.AddressNgh.Length > 30)
            {
                throw new EntityException("Invalid Address Neighborhood. Obrigatory (MaxSize = 30).");
            }
            if (this.AddressCom.Length > 10)
            {
                throw new EntityException("Invalid Address Complement. MaxSize = 10.");
            }
            if (this.AddressSta.Trim() == "" || this.AddressSta.Length > 20)
            {
                throw new EntityException("Invalid Address State. MaxSize = 20.");
            }
            if (this.TypeCli == null)
            {
                throw new EntityException("Invalid Type Customer. Empty.");
            }
            if (this.CustomerFullName.Trim() == "")
            {
                throw new EntityException("Invalid Customer Full Name. Empty.");
            }
            if (this.SocialNumber.Trim() == "")
            {
                throw new EntityException("Invalid Social Number. Empty.");
            }
            if (this.WhatsApp != null && this.WhatsApp.Length > 20)
            {
                throw new EntityException("WhatsApp Invalid. (MaxLenght 20).");
            }
            if (this.FacebookID != null && this.FacebookID.Length > 150)
            {
                throw new EntityException("FacebookID Invalid. (MaxLenght 150).");
            }
            if (this.Email != null && this.Email.Length > 50)
            {
                throw new EntityException("Email Invalid. (MaxLenght 50).");
            }
            if (this.InstagramID != null && this.InstagramID.Length > 150)
            {
                throw new EntityException("InstagramID Invalid. (MaxLenght 150).");
            }
            if(this.Email != null && emailRegExp.IsMatch(this.Email))
            {
                throw new EntityException("Email Invalid. (Regex expression invalid).");
            }
            

            return isValid;

        }
    }
}
