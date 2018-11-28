import React, { Component } from 'react';
import ReactDOM from 'react-dom';

function Welcome({ message, user }) {
  return (
    <div>
      <p>{message} {user}</p>
    </div>
  )
}

class App extends Component {
  constructor() {
    super();

    this.state = {
      name: "Dena"
    };
  };

  handleUserChange = (event) => {
    this.setState({ name: event.target.value });
  };

  render() {
    return (
      <div>
        <label htmlFor="welcome-msg">User: </label> 
        <input type="text" onChange={this.handleUserChange} />
        <Welcome message="Hola" user={this.state.name}></Welcome>
      </div>
    )
  };
};

ReactDOM.render(<App />, document.getElementById('root'));