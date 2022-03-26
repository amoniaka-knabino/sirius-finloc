import { Space } from 'antd'
import { createFromIconfontCN } from '@ant-design/icons'
import {
  FaWifi,
  FaWheelchair,
  FaQrcode,
  FaRegClock,
  FaRegCreditCard,
} from 'react-icons/fa'
import { Tag } from 'antd'
import { List, Typography, Divider } from 'antd'
import { Popover, Button } from 'antd'

const IconFont = createFromIconfontCN({
  scriptUrl: '//at.alicdn.com/t/font_8d5l8fzk5b87iudi.js',
})
const getAddressString = (address) => {
  return `${address.postCode}, ${address.townName} 
    ${address.streetName} ${address.buildingNumber}`
}
export const Baloon = (props) => {
  const address = props.data.address.postalAddressAndAdmZone.postalAddress
  return (
    <div className="baloon-content">
      {props.data.name && (
        <Typography.Text strong>{props.data.name}</Typography.Text>
      )}
      {props.data.deviceType && (
        <Typography.Text strong>
          {props.data.deviceType.split('|')[0]}
        </Typography.Text>
      )}
      <br />
      <Typography.Text type="secondary">
        {getAddressString(address)}
      </Typography.Text>

      <Divider />
      {props.data.wifi && (
        <Tag color="blue">
          <FaWifi />
        </Tag>
      )}
      {props.data.qr && (
        <Tag color="gold">
          <FaQrcode />
        </Tag>
      )}
      {props.data.equeue && <Tag color="orange">Эл.очередь</Tag>}
      {props.data.nfc && <Tag color="cyan">NFC</Tag>}
      {props.data.nfc && <Tag color="cyan">NFC</Tag>}
      {props.data.cards &&
        props.data.cards.map((card, index) => (
          <Tag key={index} color="lime">
            {<FaRegCreditCard />}
            {card}
          </Tag>
        ))}
      {props.data.accessibilities &&
        props.data.accessibilities.accessibility.map((acc, index) => (
          <Tag color="magenta" key={index}>
            {<FaWheelchair />}
            {acc.type}
          </Tag>
        ))}

      {/*props.data.cards && (
        <Popover
          content={
            <List
              bordered
              dataSource={props.data.cards}
              renderItem={(card) => (
                <List.Item>
                  <Typography.Text mark>{card.description}</Typography.Text>
                </List.Item>
              )}
            />
          }
          title="Доступны карты платежных систем"
        >
          <span>Карты</span>
        </Popover>
        )*/}
    </div>
  )
}
