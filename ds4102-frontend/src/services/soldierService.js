import axios from "axios";
import { ref } from 'vue'

const soldierService = (function(){

    const soldiers = ref([]);

    const soldierControllerUrl = "https://localhost:7203/soldier";

    ( async ()=>{
        const request = await axios.get(soldierControllerUrl);
        soldiers.value = request.data;
    })()

    const getAll = () => soldiers;

    const postSoldier = ( newSoldier ) =>

    soldiers.value.push(newSoldier)

    return {
        getAll,
        postSoldier
    }
}())

export default soldierService;