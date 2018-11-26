import React from 'react';
import ReactDOM from 'react-dom';

var person = {
    name: 'Joe Blake',
    address: 'Venezuela 4269',
    state: 'Almagro, CABA (1211)'
};

function AddressLabel (props) {
    return (
        <div>
        <span>{props.person.name}</span>,
        <span>{props.person.address}</span>,
        <span>{props.person.state}</span>
        </div>
    );
}

ReactDOM.render(<AddressLabel person={person} />, document.getElementById('root'));
