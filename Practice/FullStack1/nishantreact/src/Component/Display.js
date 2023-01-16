import {useState,useEffect} from "react";
import Service from "./Service";
import { Link } from "react-router-dom";
const Display=()=>{
    const [NishantArr,setNishantArr]=useState([]);
    useEffect (()=>{
        alert("Effect");
        Service.GetAllNishant().then((resp)=>{
            console.log(resp.data);
            setNishantArr(resp.data);
        });
    },[]);

    let Render=()=>{
        return NishantArr.map((Nish)=>{
            return <tr><td>{Nish.id}</td><td>{Nish.name}</td><td>{Nish.email}</td></tr>
        })
    }
    return(
        <div>
            <Link to="Nishant/AddNishant">
                <button id="b" name="b">Add Nishant</button>
                </Link>
            <table>
                <tr>
                    <th>ID :</th>
                    <th>Name :</th>
                    <th>Email :</th>
                </tr>
                {Render()}
            </table>
        </div>
    )
}
export default Display;