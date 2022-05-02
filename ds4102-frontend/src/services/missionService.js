import axios from "axios";
import { ref } from 'vue'

const missionService = (function(){

    const missions = ref([]);

    const missionControllerUrl = "https://localhost:7203/mission";

    ( async ()=>{
        const request = await axios.get(missionControllerUrl);
        missions.value = request.data;
    })()

    const getAll = () => missions;

    const getById = async (missionId) => {
        const request = await axios.get(`https://localhost:7203/mission/${missionId}`)
        return request.data;
    }

    const postMission = ( newMission ) =>

    missions.value.push(newMission)

    return {
        getAll,
        getById,
        postMission
    }
}())

export default missionService;