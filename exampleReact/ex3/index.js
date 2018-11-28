import React, { Component } from 'react';
import ReactDOM from 'react-dom';

function Counter({ count }) {
  return (
    <div>
      <p>Contador: {count}</p>
    </div>
  )
}

class App extends Component {
  constructor() {
    super();

    this.state = {
      count: 0
    };
  };

  handleAddCount = () => {
    this.setState(previousState => {
      return { count: previousState.count + 1 };
    });
  }

  render() {
    return (
      <div>
        <button onClick={this.handleAddCount}>Add +</button>
        <Counter count={this.state.count} />
      </div>
    )
  };
};

ReactDOM.render(<App />, document.getElementById('root'));