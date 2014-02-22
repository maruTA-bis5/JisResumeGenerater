using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace JisResumeGenerater {
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    struct PostalInfo {
        public int yid;
        public string data_type;
        public string jiscode;
        public string postcode;
        public string pref;
        public string pref_kana;
        public string city;
        public string city_kana;
        public string town;
        public string town_kana;
        public string addr_name;
        public string addr_name_kana;
        public string other;
    }
    [XmlRpcUrl("http://yubin.senmon.net/service/xmlrpc/")]
    class YubinSenmonApi : XmlRpcClientProtocol {
        [XmlRpcMethod("yubin.fetchAddressByPostcode")]
        public PostalInfo[] fetchAddressByPostcode(string postcode) {
            return (PostalInfo[])this.Invoke("fetchAddressByPostcode", new[] { postcode.Replace("-", "") });
        }

        [STAThread]
        static void Main(string[] args) {
            var api = new YubinSenmonApi();
            var response = api.fetchAddressByPostcode("211-0016");
            foreach (var data in response) {
                Console.WriteLine(String.Format(
                    "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}", data.yid, data.data_type, data.jiscode, data.postcode, data.pref, data.pref_kana, data.city, data.city_kana, data.town, data.town_kana, data.addr_name, data.addr_name_kana, data.other));
            }
        }

    }


}
