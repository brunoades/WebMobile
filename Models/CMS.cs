using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMobile.Models
{
    public class CMS
    {
        public int Id { get; set; }
        public string Slogan { get; set; }
        public string SloganAppend { get; set; }
        public string BigPicText { get; set; }
        public string FirstFeature { get; set; }
        public string SecondFeature { get; set; }
        public string ThirdFeature { get; set; }
        public string FirstTeamMemberText { get; set; }
        public string FirstTeamMemberName { get; set; }
        public string FirstTeamMemberRa { get; set; }
        public string SecondTeamMemberText { get; set; }
        public string SecondTeamMemberName { get; set; }
        public string SecondTeamMemberRa { get; set; }
    }
}