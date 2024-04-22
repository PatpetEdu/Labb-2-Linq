﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb_2___Linq.Data.Migrations
{
    /// <inheritdoc />
    public partial class generalfixestabeles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_FkCourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "FkStudentId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FkCourseId",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_FkCourseId",
                table: "Enrollments",
                column: "FkCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_FkCourseId",
                table: "Enrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments");

            migrationBuilder.AlterColumn<int>(
                name: "FkStudentId",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FkCourseId",
                table: "Enrollments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_FkCourseId",
                table: "Enrollments",
                column: "FkCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_FkStudentId",
                table: "Enrollments",
                column: "FkStudentId",
                principalTable: "Students",
                principalColumn: "StudentId");
        }
    }
}
