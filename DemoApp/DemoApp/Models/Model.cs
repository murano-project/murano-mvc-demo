using System.ComponentModel;

namespace DemoApp.Models
{
    public class Model
    {
        [DisplayName("IP")]
        public string IPs { get; set; }
        [DisplayName("Machine Name")]
        public string MachineName { get; set; }
        [DisplayName("Application Pool")]
        public string AppPool { get; set; }
    }
}