import React from "react";
import {Outlet ,Link,NavLink} from "react-router-dom";

function Navigate(){
    return(
        <div>
            <ul>
                <li> 
                    <Link to="/">home</Link>
                </li>
                <li> 
                    <NavLink to="/about" exact activeStyle={{color:red}}>About us</NavLink>
                </li>
                <li> 
                    <Link to="/help">Help - Us</Link>
                </li>
            </ul>
            <Outlet/>
            </div>
    );
}

export default Navigate;