using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager.Data
{
    [Table("User")]
    public record UserTable
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User Name")]
        public string User_Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        
    }


    [Table("Tasks")]
    public record Task
    {

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int TaskId { get; set; }


        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Taks Title")]
        public string Task_Title { get; set; }


        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Taks Describtion")]
        public string Task_describtion {  get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Start Date")]
        public string Date_start { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "End Date")]
        public string Date_end { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Time Needed")]
        public string Time_Needed { get; set;}

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Time Spent")]
        public int Time_Spent { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Priority")]
        public int Priority { get; set; }

        [Required]
        [Column(TypeName = "bit")]
        [Display(Name = "Is task checked ?")]
        public bool Done { get; set; }



        [ForeignKey("UserTable")]
        [Column(TypeName = "int")]
        public int UserId { get; set; }
    }

    [Table("History")]
    public record History
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int HistoryId { get; set; }

        [ForeignKey("Task")]
        [Column(TypeName ="int")]
        public int TaskId { get; set; }

        [ForeignKey("UserTable")]
        [Column(TypeName = "int")]
        public int UserId { get; set; }
       
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "User Name")]
        public string User_Name { get; set; }
      
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Taks Describtion")]
        public string Task_describtion { get; set; }
      
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "Start Date")]
        public string Date_start { get; set; }
       
        [Column(TypeName = "varchar(255)")]
        [Display(Name = "End Date")]
        public string Date_end { get; set; }

        [Column(TypeName = "bit")]
        [Display(Name = "Is task checked ?")]
        public bool Done { get; set; }
    }
}
