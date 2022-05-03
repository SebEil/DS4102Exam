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

    const putMission = async (editedMission) => {
        await axios.put("https://localhost:7203/mission", editedMission)
        
        const temporaryMissionArray = JSON.parse( JSON.stringify( missions.value ))

        const index = temporaryMissionArray.findIndex( mission => parseInt( mission.id ) === parseInt( editedMission.id ) );

        missions.value[index].missionName = editedMission.missionName;
        missions.value[index].missionLocation = editedMission.missionLocation;
        missions.value[index].soldiersDeployed = editedMission.soldiersDeployed;

    }


    const postMission = async ( newMission ) => {
        axios.post( missionControllerUrl, newMission )
        missions.value.push(newMission);
    }

    const deleteMission = async ( missionToDelete ) => {
        await axios.delete(`https://localhost:7203/mission/${missionToDelete}`)
        missions.value.pop(missionToDelete)
        
        
    }

    
    return {
        getAll,
        getById,
        deleteMission,
        postMission,
        putMission
    }
}())

export default missionService;