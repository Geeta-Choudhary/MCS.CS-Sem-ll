import React from 'react';
import '../Custom.css';

const CustomProgressBar = ({ bgcolor, progress, height }) => {
  const ParentDiv = {
    height: height,
    width: '100%',
    backgroundColor: '#e0e0de',
    borderRadius: 40,
    margin: 10,
  };

  const ChildDiv = {
    height: '100%',
    width: `${progress}%`,
    backgroundColor: bgcolor,
    borderRadius: 40,
    textAlign: 'right',
    transition: 'width 0.5s ease-in-out',
  };

  const ProgressText = {
    padding: 5,
    color: 'white',
    fontWeight: 'bold',
  };

  return (
    <div style={ParentDiv}>
      <div style={ChildDiv}>
        <span style={ProgressText}>{`${progress}%`}</span>
      </div>
    </div>
  );
};

export default CustomProgressBar;