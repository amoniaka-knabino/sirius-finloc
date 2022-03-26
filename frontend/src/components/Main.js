import { Col, Row } from "antd"
import Filter from "./Filter";
import Map from "./Map"
import { branchesData, devicesData } from './data'
import { useState } from "react";

const Main = () => {
  const [data, setData] = useState({ devices: [], branches: [] })

  return <div> 
      <Row>
      <Col xs={24} xl={8}>
          <Filter setData={setData}/>
      </Col>
      <Col xs={24} xl={16}>
          <Map data={data}/>
      </Col>
    </Row>
  </div>
}
export default Main;