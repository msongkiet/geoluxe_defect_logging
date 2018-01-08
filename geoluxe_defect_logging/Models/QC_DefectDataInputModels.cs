using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace geoluxe_defect_logging.Models
{
    public class QC_DefectDataInputModels
    {

    }

    // dbDesign_rev1.1_DefectLogging

    public class QC_SlabList
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Slab ID :")]
        public UInt64 SlabID { get; set; }

        [Display(Name = "Order No. :")]
        public int OrderNo { get; set; }

        [Display(Name = "Material Type :")]
        public string MatType { get; set; }

        public string Shades { get; set; }

        public float Width_1 { get; set; }
        public float Width_2 { get; set; }

        public float Length_1 { get; set; }
        public float Length_2 { get; set; }

        public float Thickness_1 { get; set; }
        public float Thickness_2 { get; set; }
        public float Thickness_3 { get; set; }
        public float Thickness_4 { get; set; }
        public float Thickness_5 { get; set; }
        public float Thickness_6 { get; set; }

        public int OperatorID { get; set; }
        //public DateTime Date_of_Entry { get; set; }

        //public string SlabStatus { get; set; }
    }

    public class QC_SlabDefectList : QC_SlabList
    {
        public bool Reprocess { get; set; }

        [Required]
        public int DefectID { get; set; }

        [Required]
        public int BasedID { get; set; }

        public int CategoryID { get; set; }

        public string GetDate { get; set; }

        public string GetTime { get; set; }

        [Required]
        [Display(Name = "Location X (mm) :")]
        public float Location_X { get; set; }

        [Required]
        [Display(Name = "Location Y (mm) :")]
        public float Location_Y { get; set; }

        public string Remark { get; set; }

    }

    public class DefectTableDTO : QC_SlabDefectList
    {
        public List<QC_SlabDefectList> QC_DefectListPreview { get; set; }

        public DefectTableDTO()
        {
            this.QC_DefectListPreview = new List<QC_SlabDefectList>();
        }
    }

    public class DBOperator
    {
        [Key]
        public int OperatorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int EmployeeID { get; set; }
    }

    public class DefectCategory_Lookup
    {
        [Key]
        public int CategoryID { get; set; }
        public int ParentID { get; set; }
        public string Description { get; set; }
        public int Revision { get; set; }
        public string Remark { get; set; }
    }

    public class QC_Defect
    {
        [Key]
        public int DefectID { get; set; }
        public int SlabID { get; set; }
        public string CategoryID { get; set; }
        public string Remark { get; set; }
    }

    public class QC_SizeDefect : QC_Defect
    {

    }

    public class QC_ChipDefect : QC_Defect
    {
        public float Size { get; set; }
    }

    public class QC_SurfaceCrackDefect : QC_Defect
    {
        public string Orientation { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
    }

    public class QC_LaminateDefect : QC_Defect
    {
        public int Number_of_Laminates { get; set; }
        public float Depth { get; set; }
        public float Length { get; set; }
    }

    public class QC_SideCrackDefect : QC_Defect
    {
        public string Orientation { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
    }

    public class QC_EdgeCrackDefect : QC_Defect
    {
        public string Orientation { get; set; }
        public int Number_of_Cracks { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
    }

    public class QC_BrokenCornerDefect : QC_Defect
    {
        public float Width { get; set; }
        public float Length { get; set; }
    }

    public class QC_BottomChipDefect : QC_Defect
    {
        public int Number_of_Chips { get; set; }
        public float Depth { get; set; }
    }

    public class QC_SwellingDefect : QC_Defect
    {

    }

    public class QC_PolishingDefect : QC_Defect
    {

    }

    public class QC_ScrubHeadDefect : QC_Defect
    {
        public float Size { get; set; }
    }

    public class QC_BackDefect : QC_Defect
    {

    }

    public class QC_BlackSpotDefect : QC_Defect
    {
        public float Size { get; set; }
    }

    public class QC_FeltMarkDefect : QC_Defect
    {

    }

    public class QC_RepairMarkDefect : QC_Defect
    {

    }

    public class QC_ColorMarkDefect : QC_Defect
    {

    }

    public class QC_BlurredPatternDefect : QC_Defect
    {

    }

    public class QC_CrookedPatternDefect : QC_Defect
    {

    }

    public class QC_ColorPatternDefect : QC_Defect
    {

    }

    public class QC_FeatherPatternDefect : QC_Defect
    {

    }

    public class QC_LayerJointsPatternDefect : QC_Defect
    {

    }

    public class QC_WavyPatternDefect : QC_Defect
    {

    }

}