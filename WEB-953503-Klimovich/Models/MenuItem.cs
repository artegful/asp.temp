using System;
namespace WEB_953503_Klimovich.Models
{
    public class MenuItem
    {
        private const string ACTIVE_CSS = "active";
        private const string INACTIVE_CSS = "";

        private bool isActive;

        public bool IsPage { get; set; } = false;
        public string Area { get; set; } = "";
        public string Controller { get; set; } = "";
        public string Action { get; set; } = "";
        public string Page { get; set; } = "";
        public string Text { get; set; } = "";

        public string Active { get; private set; } = INACTIVE_CSS;

        public bool IsActive
        {
            get => isActive;
            set
            {
                isActive = value;

                Active = value ? ACTIVE_CSS : INACTIVE_CSS;
            }
        }
    }
}
