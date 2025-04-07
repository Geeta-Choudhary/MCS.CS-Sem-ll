//import logo from './logo.svg';
import React ,{Component } from 'react';
//import React, { useState ,Component } from 'react';
import Counter from './components/Counter';
import HelloWorld from  './components/HelloWorld';
import  Form from './components/Form';
import DataFetcher from './components/DataFetcher';
import InfoFetcher from './components/InfoFetcher';
import CustomProgressBar from './components/Custom';
import './Custom.css';
import './App.css';


class App extends Component {
  constructor(props){
    super(props);
    this.state ={
      formData: [],
      progress:0,
    };
  }

  handleFormSubmit = (data) =>{
    this.setState((prevState) => ({
      formData:[...prevState.formData, data],
    }));
  };

  updateProgress =() => {
    this.setState((prevState) => ({
      progress: prevState.progress >= 100 ? 0: prevState.progress + 10 ,
    }));
  };


//function App() {
render(){
  return (

    <div className="app-container">
    
       <HelloWorld/>
       <hr/>
      <h2>Counter App</h2>
      <Counter/>
      <hr/>
      <h2 id="registration-form">Registration Form </h2>
      <Form onFormSubmit={this.handleFormSubmit}/>
      <hr/>
      <DataFetcher formData={this.state.formData}/>
      <hr/>
      <InfoFetcher/>
      <hr/>

      <CustomProgressBar bgcolor="#6a1b9a" progress={this.state.progress} height={30} />
      <button className="progress-button" onClick={this.updateProgress}>
        Advance Progress
      </button>
      
  
    </div>
    );
  }
}


export default App;
