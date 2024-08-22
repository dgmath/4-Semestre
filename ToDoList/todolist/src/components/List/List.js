import { InputList } from "../Input/Input";
import '../List/Style.css'
export const List = ({ prop, color, border, check, onChange }) => {
    return (
        <div className="list">
            {prop.map((item, index) =>
                <ul className="items" key={index} >
                    {
                        <InputList
                            texto={item.name}
                            cor={item.done ? '#6C45CE' : '#FCFCFC'}
                            corBorda={item.done ? '#FCFCFC' : '#1E123B'}
                            check={item.done}
                            onChange={() => onChange(index)}
                        />
                    }

                </ul>
            )}
        </div>




    );
}