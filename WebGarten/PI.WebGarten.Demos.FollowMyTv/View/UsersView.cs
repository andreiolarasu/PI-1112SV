﻿using System.Collections.Generic;
using System.Linq;
using PI.WebGarten.Demos.FollowMyTv.Domain.DomainModels;
using PI.WebGarten.HttpContent.Html;

namespace PI.WebGarten.Demos.FollowMyTv.View
{
    public class UsersView : MasterPageView
    {
        public UsersView( IEnumerable<User> users ) :
            base( "Users",
             H1( Text( "User List" ) )
           , Ul( users.Select( user => Li( A( ResolveUri.For( user ), user.Identity.Name ) ) ).ToArray() )
           , H2( Text( "Create a New User" ) )
           , Form("post", "/users", Label("username", "Username"), InputText("username")
                                  , Label("password", "Password"), InputText("password", true)
                                  , Label("submit", "Submit" )   , InputSubmit("Submit")
            )
         )
        {
        }
    }
}
