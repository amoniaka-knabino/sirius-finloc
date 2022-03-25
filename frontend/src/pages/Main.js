import { Col, Row } from "antd"
import Filter from "./Filter";
import Map from "./Map"

const Main = () => {
  return <div> 
      <Row>
      <Col span={16}>
          <Map/>
      </Col>
      <Col span={8}>
          <Filter/>
      </Col>
    </Row>
  </div>
}
export default Main;