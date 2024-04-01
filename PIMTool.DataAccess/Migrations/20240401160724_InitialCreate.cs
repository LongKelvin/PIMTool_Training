using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PIMTool.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Employee_GroupLeaderId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Group_GroupId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Employee_GroupLeaderId",
                table: "Group",
                column: "GroupLeaderId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Group_GroupId",
                table: "Project",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_Employee_GroupLeaderId",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Group_GroupId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_Employee_GroupLeaderId",
                table: "Group",
                column: "GroupLeaderId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Group_GroupId",
                table: "Project",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
