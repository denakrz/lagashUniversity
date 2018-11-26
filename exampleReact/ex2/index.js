import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

var returnLabel =  {
  name: "Mr. Sender",
  addressLine1: "123 Fake St.",
  addressLine2: "Boston, MA 02118"
};

var recipientLabel =  {
  name: "Mrs. Receiver",
  addressLine1: "123 Fake St.",
  addressLine2: "San Francisco, CA 94101"
};

 function Envelope(props)
 {
   return(
 <div class="envelope">
    <div className="from-label">
        <span>{props.fromPerson.name}</span> <br></br>
        <span>{props.fromPerson.addressLine1}</span> <br></br>
        <span>{props.fromPerson.addressLine2}</span> <br></br>
    </div>

    <img class="stamp" alt="image"></img>

    <div class="to-label">
        <span>{props.toPerson.name}</span> <br></br>
        <span>{props.toPerson.addressLine1}</span> <br></br>
        <span>{props.toPerson.addressLine2}</span> <br></br>
    </div>

 </div>
   )
 }

 ReactDOM.render(<Envelope toPerson={recipientLabel} fromPerson={returnLabel}/>,document.getElementById('root'));