using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C42_G01_EF03.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students_Courses",
                table: "Students_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Students_Courses");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Course_Insts");

            migrationBuilder.AddColumn<int>(
                name: "InstructorId1",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students_Courses",
                table: "Students_Courses",
                columns: new[] { "CourseId", "StudentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                columns: new[] { "CourseId", "InstructorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Courses_StudentId",
                table: "Students_Courses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId1",
                table: "Departments",
                column: "InstructorId1",
                unique: true,
                filter: "[InstructorId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_InstructorId",
                table: "Course_Insts",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_CourseId",
                table: "Course_Insts",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorId1",
                table: "Departments",
                column: "InstructorId1",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Courses_CourseId",
                table: "Students_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Students_StudentId",
                table: "Students_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_CourseId",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorId",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorId1",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Courses_CourseId",
                table: "Students_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Students_StudentId",
                table: "Students_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students_Courses",
                table: "Students_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Students_Courses_StudentId",
                table: "Students_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId1",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_InstructorId",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "InstructorId1",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Students_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students_Courses",
                table: "Students_Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                column: "ID");
        }
    }
}
