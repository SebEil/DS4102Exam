<template>
    <section>
        <h2>Army admin page</h2>
        <h3>Search here</h3>
        <label>Id</label>
        <input v-model="missionId" type="text">
        <input @click="getMission" type="button" value="Get"><br>
        <label>Name</label>
        <input v-model="missionName" type="text"><br>
        <label>Location</label>
        <input v-model="missionLocation" type="text"><br>
        <label>Soldier deployed</label>
        <input v-model="soldiersDeployed" type="text"><br>
        <input @click="changeMission" type="button" value="Save changes">
        <input @click="deleteMission" type="button" value="Delete">
        <missions-list></missions-list>


    </section>
</template>


<script>
import MissionsList from "../components/missions/MissionsList.vue"
import missionService from "../services/missionService"
import {reactive, toRefs} from 'vue'


export default {
  setup(){
       
       const missionForm = reactive({
            missionId: 1,
            missionName: "",
            missionLocation: "",
            soldiersDeployed: 1
        });

        const getMission = async () => {
            const mission = await missionService.getById(missionForm.missionId);
            missionForm.missionName = mission.missionName;
            missionForm.missionLocation = mission.missionLocation;
            missionForm.soldiersDeployed = mission.soldiersDeployed;           
        }

        const changeMission = async () => {

            const editedMission = {
                missionId: parseInt( missionForm.missionId ),
                missionName: missionForm.missionName,
                missionLocation: missionForm.missionLocation,
                soldiersDeployed: parseInt( missionForm.soldiersDeployed)
            }

            missionService.putMission( editedMission );

        }


      return{
          getMission,
          changeMission,
          ...toRefs( missionForm )
      }
  },
  components: { 
      MissionsList 
    },
  
}
</script>
