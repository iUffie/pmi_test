using PMI.BDDM.Tools;

namespace PMI.BDDM.Common.CoreCrm
{
    /// <summary>
    /// Канал поступления
    /// </summary>
    [BDDMClassInfo("Channel Type", Id = "589C8990-4195-41EA-8F76-BDB2743A8971")]
    public enum ChannelType
    {
        /// <summary>
        /// UndefinedEnumValue
        /// </summary>
        UndefinedEnumValue,

        /// <summary>
        /// POS
        /// </summary>
        [BDDMEnumLiteralInfo("POS", Alias = "POS", Id = "1E5B661B-C0C3-4D4A-98E7-AAC2B4C6C078")] POS,

        /// <summary>
        /// QPointCC
        /// </summary>
        [BDDMEnumLiteralInfo("QPointCC", Alias = "QPointCC", Id = "72E724A0-B313-4B89-B534-D1BB5D0FAD63")] QPointCC,

        /// <summary>
        /// Unrecognized
        /// </summary>
        Unrecognized,
    }
}
