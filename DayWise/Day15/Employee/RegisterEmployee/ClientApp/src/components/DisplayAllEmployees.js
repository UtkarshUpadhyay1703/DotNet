import { useState,useEffect } from "react";
import EmployeeService from "./EmployeeService";

const DisplayAllEmployees=()=>{
    let [EmpArr,setEmpArr]=useState([]);
    useEffect (()=>{
        EmployeeService.GetAllEmployees().then((result)=>{
            console.log(result);
            setEmpArr(result);
        });
    },[]);
    let Render=()=>{
        EmpArr.map((emp)=>{
            return <tr><td>{emp.employee_id}</td>
                <td>{employee_name}</td>
                <td>{employee_address}</td>
                <td>{employee_mobile_no}</td>
                <td>{employee_aadhar_no}</td>
                <td>{employee_bank_account_no}</td>
                <td>{employee_email_id}</td>
                <td>{employee_password}</td>
                <td>{employee_qualification}</td>
                <td>{employee_status}</td></tr>
        })
    }
    return(
        <div>
            <table>
                <tr>
                    <thead>
                        <th>employee_id</th><th>employee_name</th><th>employee_address</th><th>employee_mobile_no</th><th>employee_aadhar_no</th><th>employee_bank_account_no</th><th>employee_email_id</th><th>employee_password</th><th>employee_qualification</th><th>employee_status</th>
                    </thead>
                </tr>
                {Render()}
            </table>
        </div>
    )
}
export default DisplayAllEmployees;