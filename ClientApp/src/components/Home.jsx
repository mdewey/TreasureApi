import React, { useState } from 'react';

const Home = () =>  {
  
  const [minor, setMinor] = useState(8);
  const [medium, setMedium] = useState(3);
  const [major, setMajor] = useState(5);

  const  formSubmit = async (e) => {
    e.preventDefault()
    const resp = await fetch(`/api/treasure?minor=${minor}&medium=${medium}&major=${major}`)
    const json = await resp.json();

    console.log({json});
  }

  
  return (
    <div>
      <h1>Treasure!</h1>
      <form onSubmit={formSubmit}>
        <input type="number" value={minor} onChange={e => setMinor(e.target.value)} placeholder="minor"/>
        <input type="number" value={medium} onChange={e => setMedium(e.target.value)} placeholder="medium"/>
        <input type="number" value={major} onChange={e => setMajor(e.target.value)}  placeholder="major"/>
        <button type="submit">Go</button>
      </form>
    </div>
  );
}


export {Home}