using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace backend.Models
{
    public class Filter
    {
        public bool wifi { get; set; }
        public bool access24Hourse { get; set; }
        public bool equeue { get; set; }
        public bool nfc { get; set; }
        public bool qr { get; set; }
        public List<Accessibility> Accessibilities { get; set; }
        public List<Card> Cards { get; set; }
    }

    public enum Accessibility
    {
        [Description("Braille | Шрифт Брайля")] Braille,
        [Description("AudioCashMachine | Голосовое озвучивание")] AudioCashMachine,
        [Description("AutomaticDoors | Автоматические двери")] AutomaticDoors,
        [Description("WheelchairAccess | Доступность для инвалидных колясок")] WheelchairAccess,
        [Description("ExternalRamp | Внешний пандус")] ExternalRamp,
        [Description("InternalRamp | Внутренний пандус")] InternalRamp,
        [Description("Other | Другие")] Other,
    }

    public enum Card
    {
        [Description("AmericanExpress | Международная платежная система")] AmericanExpress,
        [Description("Diners | Международная платежная система")] Diners,
        [Description("Discover | Международная платежная система")] Discover,
        [Description("MasterCard | Международная платежная система")] MasterCard,
        [Description("VISA | Международная платежная система")] VISA,
        [Description("MIR | Российская национальная платежная система")] MIR,
        [Description("ArCa | Армянская национальная платежная система")] ArCa,
        [Description("BELKART | Белорусская национальная платежная система")] BELKART,
        [Description("ELCART | Киргизская национальная платежная система")] ELCART,
        [Description("JCB | Платежная система Японии")] JCB,
        [Description("UnionPay | Национальная платежная система Китая")] UnionPay
    }

    internal static class Extensions
    {
        public static string ToDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
