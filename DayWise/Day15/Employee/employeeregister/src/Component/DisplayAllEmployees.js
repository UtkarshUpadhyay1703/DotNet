import { useState,useEffect } from "react";
import EmployeeService from "./EmployeeService";

const DisplayAllEmployees=()=>{
    const [EmpArr,setEmpArr]=useState([]);
    useEffect (()=>{
        EmployeeService.GetAllEmployees().then((result)=>{
            console.log(result);
            setEmpArr(result);
        });
    },[]);
    let Render=()=>{
        return EmpArr.map((emp)=>{
            return <tr key={emp.employee_id}><td>{emp.employee_id}</td><td>{emp.employee_name}</td><td>{emp.employee_address}</td><td>{emp.employee_mobile_no}</td><td>{emp.employee_aadhar_no}</td><td>{emp.employee_bank_account_no}</td><td>{emp.employee_email_id}</td><td>{emp.employee_password}</td><td>{emp.employee_qualification}</td><td>{emp.employee_status}</td></tr>
        })
    }
    return(
        <div>
            <table>
                    <thead><tr>
                        <th>employee_id</th><th>employee_name</th><th>employee_address</th><th>employee_mobile_no</th><th>employee_aadhar_no</th><th>employee_bank_account_no</th><th>employee_email_id</th><th>employee_password</th><th>employee_qualification</th><th>employee_status</th>
                        </tr>
                    </thead>
                {Render()}
            </table>
        </div>
    )
}
export default DisplayAllEmployees;