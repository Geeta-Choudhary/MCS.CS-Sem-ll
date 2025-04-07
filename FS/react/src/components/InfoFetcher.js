import React, { Component } from 'react';
import '../InfoFetcher.css'; 

class InfoFetcher extends Component {
  constructor(props) {
    super(props);
    this.state = {
      data: [],
      isLoading:true,
      error:null,
    };
  }

  // Fetch data after the component mounts
  componentDidMount() {
    fetch('https://fakestoreapi.com/products') 
      .then((response) => {
        if(!response.ok) {
            throw new Error(`HTTp error ! Status :${response.status}`);
        }
        return response.json();
      })
      .then((json) => this.setState({ data: json.slice(0, 5),isLoading:false })) 
      .catch((error) => this.setState( {error, isLoading:false}));
  }

  render() 
    {
        const { data, isLoading, error } = this.state;
    
        if (isLoading) {
          return <div>Loading...</div>;
        }
    
        if (error) {
          return <div>Error: {error.message}</div>;
        }
    



    return (
      <div className="data-container">
        <h2>Fetched Data</h2>
        <ul>
          {data.map((item) => (
            <li key={item.id}>
              <strong>{item.title}</strong>
              <p>{item.body}</p>
            </li>
          ))}
        </ul>
      </div>
    );
  }
}

export default InfoFetcher;