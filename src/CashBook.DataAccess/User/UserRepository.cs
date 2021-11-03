﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Models.User;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Dapper;

namespace CashBook.DataAccess.User
{
    public class UserRepository : IUserRepository
    {
        IDbConnection dbConnection
        {
            get
            {
                return new FbConnection(Utility.ConnectionString);
            }
        }
        public void CreateNewUser(UserModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                INSERT INTO 
                                    Users (UserId, UserName, UserPassword, FullName, TelephoneNumber,EmailAddress, SecurityQuestion, SecurityAnswer, IsDeleted,CreatedAt, UpdatedAt)
                                VALUES
                                    (@UserId, @UserName, @UserPassword, @FullName, @TelephoneNumber, @EmailAddress, @SecurityQuestion, @SecurityAnswer, @IsDeleted, @CreatedAt, @UpdatedAt);
                                ";
                connection.Execute(query,model);
            }
        }

        public UserModel GetUserByUserId(string userId)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT
                                    UserId, UserName, UserPassword, FullName, TelephoneNumber,EmailAddress, SecurityQuestion, SecurityAnswer, IsDeleted,CreatedAt, UpdatedAt
                                FROM
                                    Users
                                WHERE
                                    UserId=@UserId AND IsDeleted=false
                                ";
                return connection.Query<UserModel>(query,new { UserId = userId}).SingleOrDefault();
            }
        }

        public UserModel GetUserByUsername(string username)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                SELECT
                                    UserId, UserName, UserPassword, FullName, TelephoneNumber,EmailAddress, SecurityQuestion, SecurityAnswer, IsDeleted,CreatedAt, UpdatedAt
                                FROM
                                    Users
                                WHERE
                                    UserName=@UserNAme AND IsDeleted=false
                                ";
                return connection.Query<UserModel>(query, new { UserName = username }).SingleOrDefault();
            }
        }

        public void UpdateUser(UserModel model)
        {
            using (IDbConnection connection = dbConnection)
            {
                connection.Open();
                string query = @"
                                UPDATE
                                    Users
                                SET
                                    UserId=@UserId, UserName=@UserName, UserPassword=@UserPassword, FullName=@FullName, TelephoneNumber=@TelephoneNumber,EmailAddress=@EmailAddress, SecurityQuestion=@SecurityQuestion, SecurityAnswer=@SecurityAnswer,UpdatedAt=@UpdatedAt
                                WHERE
                                    UserId=@UserId AND IsDeleted=false
                                ";
                connection.Execute(query,model);
            }
        }
    }
}
